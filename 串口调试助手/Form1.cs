using System.IO.Ports;
using System.Security;
using System.Text;
using System.Windows.Forms;
namespace 串口调试助手
{
    public partial class Form1 : Form
    {
        //实例化串口类
        private readonly SerialPort sp = new SerialPort();
        //实例化计时器
        private System.Windows.Forms.Timer sendTimer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            InitUI();
        }

        //窗体初始化
        private void InitUI()
        {
            //初始化串口号、波特率、数据位、校验位、停止位
            this.comboPort.SelectedIndex = 0;
            this.comboBaudRate.SelectedIndex = 0;
            this.comboParity.SelectedIndex = 0;
            this.comboDataBits.SelectedIndex = 0;
            this.comboStopBits.SelectedIndex = 0;
            //初始化默认选择以字符串发送
            this.radioDisplayString.Checked = true;
            this.txtAutoSendTime.Text = "1000";
            //定时器初始化
            sendTimer.Interval = 1000;
            sendTimer.Tick += SendTimer_Tick;
        }

        //“打开串口”按钮方法
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sp.IsOpen)
                {
                    sp.PortName = comboPort.Text;
                    sp.BaudRate = int.Parse(comboBaudRate.Text);
                    sp.DataBits = int.Parse(comboDataBits.Text);
                    sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboStopBits.Text);
                    sp.Parity = (Parity)Enum.Parse(typeof(Parity), comboParity.Text);
                    sp.DataReceived += Sp_DataReceived;
                    sp.Open();

                    btnOpenPort.Text = "关闭串口";
                    btnOpenPort.BackColor = Color.Red;
                    AppendLog("串口已打开\n");

                }
                else
                {
                    //解绑事件
                    sp.DataReceived -= Sp_DataReceived;
                    sp.Close();
                    btnOpenPort.Text = "打开串口";
                    btnOpenPort.BackColor = Color.White;
                    AppendLog("串口已关闭\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"串口操作失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //接收数据事件
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count = sp.BytesToRead;
                byte[] data = new byte[count];
                sp.Read(data, 0, count);


                if (data.Length > 0)//避免在勾选了换行和时间戳后会多显示出空的换行和时间戳
                {
                    string message = radioDisplayString.Checked ? Encoding.Default.GetString(data) : ByteArrayToHex(data);
                    string time = chkShowTimestamp.Checked ? $"[{DateTime.Now:yyyy - MM - dd HH:mm:ss.fff}]" : string.Empty;
                    string suffix = chkNewLine.Checked ? "\r\n" : string.Empty;

                    AppendLog($"{time}{message}{suffix}");
                }


                }
            catch (Exception ex)
            {
                AppendLog($"接收数据出错：{ex.Message}");
            }
        }

        //点击“发送数据”按钮方法
        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (chkAutoSend.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtAutoSendTime.Text))
                {
                    MessageBox.Show("勾选定时发送后，请设置定时发送的间隔时间");
                    return;
                }

                sendTimer.Interval=int.Parse(txtAutoSendTime.Text);
                sendTimer.Start();
                SendTimer_Tick(sender, e);
            }
            else
            {
                SendData();//发送一次
            }
            
        }

        //字节数组转换为十六进制字符串
        private static string ByteArrayToHex(byte[] data)
        {
            return BitConverter.ToString(data, 0, data.Length);
        }

        //十六进制转换字节数组方法
        private static byte[] HexStringToBytes(string hex)
        {
            hex = hex.Replace(" ", "");
            if (hex.Length % 2 != 0)
            {
                hex = "0" + hex;
            }
            int len = hex.Length / 2;
            byte[] bytes = new byte[len];
            for (int i = 0; i < len; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2,2), 16);
            }
            return bytes;
        }
        //更新显示框数据
        private void AppendLog(string text)
        {
            if (rtbReceive.InvokeRequired)
            {
                rtbReceive.Invoke(new Action<string>(AppendLog), text);
            }
            else
            {
                rtbReceive.AppendText(text);
            }
        }

        //清空数据接收框
        private void btnClearReceiveData_Click(object sender, EventArgs e)
        {
            rtbReceive.Clear();
        }

        //定时发送数据事件
        private void SendTimer_Tick(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                SendData();
            }
            else
            {
                sendTimer.Stop();
            }
        }

        //限制定时时间只能设置为时间
        private void txtAutoSendTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只允许数字与退格
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //抽象出发送数据的方法
        private bool SendData()
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("请先打开串口");
                return false;
            }

            string sendText = txtSendData.Text;
            if (string.IsNullOrEmpty(sendText)) { return true; }

            try
            {
                byte[] buffer;
                if (radioDisplayString.Checked)
                {
                    //字符串模式直接编码
                    buffer = Encoding.Default.GetBytes(sendText);
                }
                else//十六进制发送
                {
                    string hexText = sendText.Replace(" ", "");
                    if (!IsValidHexString(hexText)) {
                        MessageBox.Show("请输入合法的十六进制字符 (0-9,A-F), 可以用空格分隔字节");
                        return false;
                    }

                    buffer=HexStringToBytes(hexText);
                }

                sp.Write(buffer,0,buffer.Length);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发送失败：{ex.Message}");
                return false;
            }
        }

        //停止发送数据按钮
        private void btnStopSendData_Click(object sender, EventArgs e)
        {
            sendTimer.Stop();
        }

        //检测用户在勾选了以十六进制显示后，发送的内容是否符合十六进制的规则方法
        private static bool IsValidHexString(string hex)
        {
            if (string.IsNullOrEmpty(hex)) {  return false; }

            foreach(char c in hex)
            {
                if(!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' || c <= 'f')))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
