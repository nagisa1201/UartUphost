using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace uart_serial
{
    public partial class UpHostForm : System.Windows.Forms.Form
    {
        public UpHostForm()
        {
            InitializeComponent();
            DisplayText.ReadOnly = true; // 设置为只读，防止用户编辑
            serialPort.DataReceived += SerialDataReceived; // 运用了事件和委托的写法，DataReceived是调用库类的一个事件，SerialDataReceived是自行定义的事件处理函数，+=是将事件和事件处理函数关联起来
        }
        /// <summary>
        /// 打开/关闭串口按钮回调
        /// </summary>
        private void OpenSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    OpenSerial.Text = "打开串口";
                    DisplayText.AppendText("串口已关闭\r\n");
                    //允许修改串口设置
                    SerialBox.Enabled = true;
                    BaudBox.Enabled = true;
                    FindSerial.Enabled = true;
                }
                else
                {
                    if (SerialBox.SelectedItem == null)
                    {
                        MessageBox.Show("请先选择串口", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 检查是否选择了波特率
                    if (BaudBox.SelectedItem == null)
                    {
                        MessageBox.Show("请先选择波特率", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 设置串口参数
                    serialPort.PortName = SerialBox.SelectedItem.ToString();
                    serialPort.BaudRate = int.Parse(BaudBox.SelectedItem.ToString());
                    serialPort.Parity = Parity.None;       // 无奇偶校验
                    serialPort.DataBits = 8;               // 8位数据位
                    serialPort.StopBits = StopBits.One;    // 1位停止位
                    serialPort.ReadTimeout = 500;          // 读取超时
                    serialPort.WriteTimeout = 500;         // 写入超时

                    // 打开串口
                    serialPort.Open();
                    OpenSerial.Text = "关闭串口";
                    DisplayText.AppendText($"串口 {serialPort.PortName} 已打开，波特率 {serialPort.BaudRate}\r\n");

                    // 打开后禁用修改串口和波特率
                    SerialBox.Enabled = false;
                    BaudBox.Enabled = false;
                    FindSerial.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开串口失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 检测串口按键回调
        /// </summary>
        private void FindSerial_Click(object sender, EventArgs e)
        {
            SerialBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length == 0)
            {
                DisplayText.AppendText("没找到能用的串口");
                return;
            }
            foreach (string port in ports)
            {
                SerialBox.Items.Add(port);
            }
            DisplayText.AppendText("找到" + ports.Length.ToString() + "个串口\r\n");
        }

        /// <summary>
        /// 清除显示区按键回调
        /// </summary>
        private void ClearFlush_Click(object sender, EventArgs e)
        {
            DisplayText.Clear();
        }
        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen) return;
                // 读取串口数据
                int bytesToRead = serialPort.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                serialPort.Read(buffer, 0, bytesToRead);

                // 转换为字符串
                string receivedData = System.Text.Encoding.Default.GetString(buffer);

                // 跨线程更新UI
                if (DisplayText.InvokeRequired)
                {
                    // 如果当前线程不是UI线程，通过Invoke切换到UI线程,Invoke通过InvokeRequired属性判断是否在UI线程中，如果不在，就委托交给UI线程处理
                    DisplayText.Invoke(new Action<string>(ShowData), receivedData);
                }
                else
                {
                    ShowData(receivedData);
                }
            }
            catch (Exception ex)
            {
                DisplayText.AppendText($"数据接收错误: {ex.Message}\r\n");
            }
        }
        /// <summary>
        /// 在显示框显示接收到的数据
        /// </summary>
        private void ShowData(string data)
        {
            // 添加时间戳
            string timeStamp = $"[{DateTime.Now:HH:mm:ss.fff}] ";
            DisplayText.AppendText(timeStamp + data + "\r\n");

            // 自动滚动到底部
            DisplayText.SelectionStart = DisplayText.TextLength;
            DisplayText.ScrollToCaret();
        }
        private void FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
