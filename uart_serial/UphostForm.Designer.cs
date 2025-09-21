namespace uart_serial
{
    partial class UpHostForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpHostForm));
            this.OpenSerial = new System.Windows.Forms.Button();
            this.FindSerial = new System.Windows.Forms.Button();
            this.ClearFlush = new System.Windows.Forms.Button();
            this.LabelSerialNum = new System.Windows.Forms.Label();
            this.LabelBaud = new System.Windows.Forms.Label();
            this.SerialBox = new System.Windows.Forms.ComboBox();
            this.BaudBox = new System.Windows.Forms.ComboBox();
            this.DisplayText = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // OpenSerial
            // 
            this.OpenSerial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenSerial.BackgroundImage")));
            this.OpenSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenSerial.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.OpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenSerial.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenSerial.Location = new System.Drawing.Point(56, 51);
            this.OpenSerial.Margin = new System.Windows.Forms.Padding(5);
            this.OpenSerial.Name = "OpenSerial";
            this.OpenSerial.Size = new System.Drawing.Size(218, 94);
            this.OpenSerial.TabIndex = 0;
            this.OpenSerial.Text = "打开串口";
            this.OpenSerial.UseVisualStyleBackColor = true;
            this.OpenSerial.Click += new System.EventHandler(this.OpenSerial_Click);
            // 
            // FindSerial
            // 
            this.FindSerial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindSerial.BackgroundImage")));
            this.FindSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FindSerial.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FindSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindSerial.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FindSerial.Location = new System.Drawing.Point(310, 51);
            this.FindSerial.Margin = new System.Windows.Forms.Padding(5);
            this.FindSerial.Name = "FindSerial";
            this.FindSerial.Size = new System.Drawing.Size(218, 94);
            this.FindSerial.TabIndex = 1;
            this.FindSerial.Text = "检测串口";
            this.FindSerial.UseVisualStyleBackColor = true;
            this.FindSerial.Click += new System.EventHandler(this.FindSerial_Click);
            // 
            // ClearFlush
            // 
            this.ClearFlush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearFlush.BackgroundImage")));
            this.ClearFlush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClearFlush.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ClearFlush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFlush.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClearFlush.Location = new System.Drawing.Point(1142, 729);
            this.ClearFlush.Margin = new System.Windows.Forms.Padding(5);
            this.ClearFlush.Name = "ClearFlush";
            this.ClearFlush.Size = new System.Drawing.Size(418, 101);
            this.ClearFlush.TabIndex = 2;
            this.ClearFlush.Text = "清除缓存";
            this.ClearFlush.UseVisualStyleBackColor = true;
            this.ClearFlush.Click += new System.EventHandler(this.ClearFlush_Click);
            // 
            // LabelSerialNum
            // 
            this.LabelSerialNum.BackColor = System.Drawing.Color.Transparent;
            this.LabelSerialNum.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSerialNum.Location = new System.Drawing.Point(39, 180);
            this.LabelSerialNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelSerialNum.Name = "LabelSerialNum";
            this.LabelSerialNum.Size = new System.Drawing.Size(218, 55);
            this.LabelSerialNum.TabIndex = 3;
            this.LabelSerialNum.Text = "串口号";
            this.LabelSerialNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBaud
            // 
            this.LabelBaud.BackColor = System.Drawing.Color.Transparent;
            this.LabelBaud.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelBaud.Location = new System.Drawing.Point(39, 252);
            this.LabelBaud.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelBaud.Name = "LabelBaud";
            this.LabelBaud.Size = new System.Drawing.Size(218, 55);
            this.LabelBaud.TabIndex = 4;
            this.LabelBaud.Text = "波特率";
            this.LabelBaud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SerialBox
            // 
            this.SerialBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerialBox.FormattingEnabled = true;
            this.SerialBox.Location = new System.Drawing.Point(265, 194);
            this.SerialBox.Margin = new System.Windows.Forms.Padding(5);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(273, 39);
            this.SerialBox.TabIndex = 5;
            // 
            // BaudBox
            // 
            this.BaudBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaudBox.FormattingEnabled = true;
            this.BaudBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74800",
            "115200",
            "230400",
            "460800",
            "500000",
            "576000"});
            this.BaudBox.Location = new System.Drawing.Point(265, 264);
            this.BaudBox.Margin = new System.Windows.Forms.Padding(5);
            this.BaudBox.Name = "BaudBox";
            this.BaudBox.Size = new System.Drawing.Size(273, 39);
            this.BaudBox.TabIndex = 6;
            // 
            // DisplayText
            // 
            this.DisplayText.BackColor = System.Drawing.Color.White;
            this.DisplayText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DisplayText.Location = new System.Drawing.Point(576, 53);
            this.DisplayText.Margin = new System.Windows.Forms.Padding(5);
            this.DisplayText.Multiline = true;
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(985, 641);
            this.DisplayText.TabIndex = 7;
            // 
            // UpHostForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1361, 738);
            this.Controls.Add(this.DisplayText);
            this.Controls.Add(this.BaudBox);
            this.Controls.Add(this.SerialBox);
            this.Controls.Add(this.LabelBaud);
            this.Controls.Add(this.LabelSerialNum);
            this.Controls.Add(this.ClearFlush);
            this.Controls.Add(this.FindSerial);
            this.Controls.Add(this.OpenSerial);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpHostForm";
            this.Text = "Nagisa的串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenSerial;
        private System.Windows.Forms.Button FindSerial;
        private System.Windows.Forms.Button ClearFlush;
        private System.Windows.Forms.Label LabelSerialNum;
        private System.Windows.Forms.Label LabelBaud;
        private System.Windows.Forms.ComboBox SerialBox;
        private System.Windows.Forms.ComboBox BaudBox;
        private System.Windows.Forms.TextBox DisplayText;
        private System.IO.Ports.SerialPort serialPort;
    }
}

