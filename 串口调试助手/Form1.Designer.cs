namespace 串口调试助手
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPort = new Label();
            comboPort = new ComboBox();
            rtbReceive = new RichTextBox();
            comboBaudRate = new ComboBox();
            labelBaudRate = new Label();
            comboDataBits = new ComboBox();
            labelDataBits = new Label();
            comboParity = new ComboBox();
            labelParity = new Label();
            comboStopBits = new ComboBox();
            labelStopBits = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSendData = new TextBox();
            chkAutoSend = new CheckBox();
            txtAutoSendTime = new TextBox();
            label9 = new Label();
            btnSendData = new Button();
            btnClearReceiveData = new Button();
            radioDisplayString = new RadioButton();
            radioDisplayHex = new RadioButton();
            chkNewLine = new CheckBox();
            chkShowTimestamp = new CheckBox();
            btnOpenPort = new Button();
            btnStopSendData = new Button();
            SuspendLayout();
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(49, 71);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(73, 20);
            labelPort.TabIndex = 0;
            labelPort.Text = "串口选择";
            // 
            // comboPort
            // 
            comboPort.FormattingEnabled = true;
            comboPort.Items.AddRange(new object[] { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8" });
            comboPort.Location = new Point(128, 68);
            comboPort.Name = "comboPort";
            comboPort.Size = new Size(151, 28);
            comboPort.TabIndex = 1;
            // 
            // rtbReceive
            // 
            rtbReceive.Location = new Point(372, 68);
            rtbReceive.Name = "rtbReceive";
            rtbReceive.ReadOnly = true;
            rtbReceive.Size = new Size(468, 187);
            rtbReceive.TabIndex = 2;
            rtbReceive.Text = "";
            // 
            // comboBaudRate
            // 
            comboBaudRate.FormattingEnabled = true;
            comboBaudRate.Items.AddRange(new object[] { "9600", "19200", "38400", "76800", "153600" });
            comboBaudRate.Location = new Point(128, 129);
            comboBaudRate.Name = "comboBaudRate";
            comboBaudRate.Size = new Size(151, 28);
            comboBaudRate.TabIndex = 4;
            // 
            // labelBaudRate
            // 
            labelBaudRate.AutoSize = true;
            labelBaudRate.Location = new Point(49, 132);
            labelBaudRate.Name = "labelBaudRate";
            labelBaudRate.Size = new Size(57, 20);
            labelBaudRate.TabIndex = 3;
            labelBaudRate.Text = "波特率";
            // 
            // comboDataBits
            // 
            comboDataBits.FormattingEnabled = true;
            comboDataBits.Items.AddRange(new object[] { "7", "8" });
            comboDataBits.Location = new Point(128, 193);
            comboDataBits.Name = "comboDataBits";
            comboDataBits.Size = new Size(151, 28);
            comboDataBits.TabIndex = 6;
            // 
            // labelDataBits
            // 
            labelDataBits.AutoSize = true;
            labelDataBits.Location = new Point(49, 196);
            labelDataBits.Name = "labelDataBits";
            labelDataBits.Size = new Size(57, 20);
            labelDataBits.TabIndex = 5;
            labelDataBits.Text = "数据位";
            // 
            // comboParity
            // 
            comboParity.FormattingEnabled = true;
            comboParity.Items.AddRange(new object[] { "None", "Add", "Even" });
            comboParity.Location = new Point(128, 258);
            comboParity.Name = "comboParity";
            comboParity.Size = new Size(151, 28);
            comboParity.TabIndex = 8;
            // 
            // labelParity
            // 
            labelParity.AutoSize = true;
            labelParity.Location = new Point(49, 261);
            labelParity.Name = "labelParity";
            labelParity.Size = new Size(57, 20);
            labelParity.TabIndex = 7;
            labelParity.Text = "校验位";
            // 
            // comboStopBits
            // 
            comboStopBits.FormattingEnabled = true;
            comboStopBits.Items.AddRange(new object[] { "1", "2" });
            comboStopBits.Location = new Point(128, 321);
            comboStopBits.Name = "comboStopBits";
            comboStopBits.Size = new Size(151, 28);
            comboStopBits.TabIndex = 10;
            // 
            // labelStopBits
            // 
            labelStopBits.AutoSize = true;
            labelStopBits.Location = new Point(49, 324);
            labelStopBits.Name = "labelStopBits";
            labelStopBits.Size = new Size(57, 20);
            labelStopBits.TabIndex = 9;
            labelStopBits.Text = "停止位";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(25, 31);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 11;
            label6.Text = "串口设置";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(322, 31);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 12;
            label7.Text = "数据接收";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(322, 282);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 13;
            label8.Text = "数据发送";
            // 
            // txtSendData
            // 
            txtSendData.Location = new Point(372, 321);
            txtSendData.Multiline = true;
            txtSendData.Name = "txtSendData";
            txtSendData.Size = new Size(468, 95);
            txtSendData.TabIndex = 14;
            // 
            // chkAutoSend
            // 
            chkAutoSend.AutoSize = true;
            chkAutoSend.Location = new Point(372, 439);
            chkAutoSend.Name = "chkAutoSend";
            chkAutoSend.Size = new Size(95, 24);
            chkAutoSend.TabIndex = 15;
            chkAutoSend.Text = "定时发送";
            chkAutoSend.UseVisualStyleBackColor = true;
            // 
            // txtAutoSendTime
            // 
            txtAutoSendTime.Location = new Point(372, 472);
            txtAutoSendTime.Name = "txtAutoSendTime";
            txtAutoSendTime.Size = new Size(42, 27);
            txtAutoSendTime.TabIndex = 16;
            txtAutoSendTime.KeyPress += txtAutoSendTime_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(420, 475);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 17;
            label9.Text = "ms/1次";
            // 
            // btnSendData
            // 
            btnSendData.Location = new Point(498, 472);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(94, 29);
            btnSendData.TabIndex = 18;
            btnSendData.Text = "发送数据";
            btnSendData.UseVisualStyleBackColor = true;
            btnSendData.Click += btnSendData_Click;
            // 
            // btnClearReceiveData
            // 
            btnClearReceiveData.Location = new Point(720, 472);
            btnClearReceiveData.Name = "btnClearReceiveData";
            btnClearReceiveData.Size = new Size(120, 29);
            btnClearReceiveData.TabIndex = 19;
            btnClearReceiveData.Text = "清空接送数据";
            btnClearReceiveData.UseVisualStyleBackColor = true;
            btnClearReceiveData.Click += btnClearReceiveData_Click;
            // 
            // radioDisplayString
            // 
            radioDisplayString.AutoSize = true;
            radioDisplayString.Location = new Point(49, 379);
            radioDisplayString.Name = "radioDisplayString";
            radioDisplayString.Size = new Size(78, 24);
            radioDisplayString.TabIndex = 20;
            radioDisplayString.TabStop = true;
            radioDisplayString.Text = "字符串";
            radioDisplayString.UseVisualStyleBackColor = true;
            // 
            // radioDisplayHex
            // 
            radioDisplayHex.AutoSize = true;
            radioDisplayHex.Location = new Point(216, 379);
            radioDisplayHex.Name = "radioDisplayHex";
            radioDisplayHex.Size = new Size(94, 24);
            radioDisplayHex.TabIndex = 21;
            radioDisplayHex.TabStop = true;
            radioDisplayHex.Text = "十六进制";
            radioDisplayHex.UseVisualStyleBackColor = true;
            // 
            // chkNewLine
            // 
            chkNewLine.AutoSize = true;
            chkNewLine.Location = new Point(49, 430);
            chkNewLine.Name = "chkNewLine";
            chkNewLine.Size = new Size(95, 24);
            chkNewLine.TabIndex = 22;
            chkNewLine.Text = "换行显示";
            chkNewLine.UseVisualStyleBackColor = true;
            // 
            // chkShowTimestamp
            // 
            chkShowTimestamp.AutoSize = true;
            chkShowTimestamp.Location = new Point(216, 430);
            chkShowTimestamp.Name = "chkShowTimestamp";
            chkShowTimestamp.Size = new Size(79, 24);
            chkShowTimestamp.TabIndex = 23;
            chkShowTimestamp.Text = "时间戳";
            chkShowTimestamp.UseVisualStyleBackColor = true;
            // 
            // btnOpenPort
            // 
            btnOpenPort.Location = new Point(81, 472);
            btnOpenPort.Name = "btnOpenPort";
            btnOpenPort.Size = new Size(198, 61);
            btnOpenPort.TabIndex = 24;
            btnOpenPort.Text = "打开串口";
            btnOpenPort.UseVisualStyleBackColor = true;
            btnOpenPort.Click += btnOpenPort_Click;
            // 
            // btnStopSendData
            // 
            btnStopSendData.Location = new Point(608, 472);
            btnStopSendData.Name = "btnStopSendData";
            btnStopSendData.Size = new Size(94, 29);
            btnStopSendData.TabIndex = 25;
            btnStopSendData.Text = "停止发送";
            btnStopSendData.UseVisualStyleBackColor = true;
            btnStopSendData.Click += btnStopSendData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(879, 598);
            Controls.Add(btnStopSendData);
            Controls.Add(btnOpenPort);
            Controls.Add(chkShowTimestamp);
            Controls.Add(chkNewLine);
            Controls.Add(radioDisplayHex);
            Controls.Add(radioDisplayString);
            Controls.Add(btnClearReceiveData);
            Controls.Add(btnSendData);
            Controls.Add(label9);
            Controls.Add(txtAutoSendTime);
            Controls.Add(chkAutoSend);
            Controls.Add(txtSendData);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboStopBits);
            Controls.Add(labelStopBits);
            Controls.Add(comboParity);
            Controls.Add(labelParity);
            Controls.Add(comboDataBits);
            Controls.Add(labelDataBits);
            Controls.Add(comboBaudRate);
            Controls.Add(labelBaudRate);
            Controls.Add(rtbReceive);
            Controls.Add(comboPort);
            Controls.Add(labelPort);
            Name = "Form1";
            Text = "串口调试助手";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPort;
        private ComboBox comboPort;
        private RichTextBox rtbReceive;
        private ComboBox comboBaudRate;
        private Label labelBaudRate;
        private ComboBox comboDataBits;
        private Label labelDataBits;
        private ComboBox comboParity;
        private Label labelParity;
        private ComboBox comboStopBits;
        private Label labelStopBits;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSendData;
        private CheckBox chkAutoSend;
        private TextBox txtAutoSendTime;
        private Label label9;
        private Button btnSendData;
        private Button btnClearReceiveData;
        private RadioButton radioDisplayString;
        private RadioButton radioDisplayHex;
        private CheckBox chkNewLine;
        private CheckBox chkShowTimestamp;
        private Button btnOpenPort;
        private Button btnStopSendData;
    }
}
