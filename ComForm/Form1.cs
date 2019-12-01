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
using COMLIB;

namespace ComForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SerialPortDebugHelper debugHelper;
        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化
            initBase();
            //初始化串口
            this.comboPortNames.Items.AddRange(SerialPort.GetPortNames());
            //初始化波特率
            this.comboBaudRate.Items.AddRange(GetRaudRates());
            //初始化数据位
            this.comboDataBits.Items.AddRange(GetDataBits());
            //初始化校验位
            this.comboparity.Items.AddRange(GetParitys());
            //初始化停止位
            this.comboStopBits.Items.AddRange(GetStopBits());
            //初始化发送配置
            InitSendConfig();
            //初始化接收配置
            InitReviceConfig();

            //设置默认配置
            InitDefault();
        }

        private void InitDefault()
        {
            this.comboBaudRate.Text = "115200";
            this.comboDataBits.Text = "8";
            this.comboparity.Text = "None";
            this.comboStopBits.Text = "1";
           
        }

        private void initBase()
        {
            this.checkAutoSd.Enabled = false;
            this.numSdInvertal.Enabled = false;
            this.timer1.Enabled = false;
            this.serialPort1 = new SerialPort();
            debugHelper = new SerialPortDebugHelper(serialPort1);
            this.debugHelper.onSerialDataReceiveData += DebugHelper_onSerialDataReceiveData;

        }

        private void DebugHelper_onSerialDataReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke((EventHandler)delegate
            {
                if (this.checkShowReTime.Checked)
                {
                    string time = DateTime.Now.ToString("HH:mm:ss") + "：";
                    string tempcontent = time + this.debugHelper.ReviceDataContent.ToString();
                    this.txtBoxRe.AppendText(tempcontent);
                }
                else
                {
                    this.txtBoxRe.AppendText(this.debugHelper.ReviceDataContent.ToString());
                }
                this.lblRevice.Text = "Rx:"+this.debugHelper.ReviceDataLenght.ToString()+"Bytes";
            });
        }

        private void InitReviceConfig()
        {
            this.radioReASCII.Checked = true;

        }

        private void InitSendConfig()
        {
            this.radioSdASCII.Checked = true;
        }

        private object[] GetStopBits()
        {
            object[] items = new object[] { 1, 1.5, 2 };
            return items;
        }

        private object[] GetParitys()
        {
            string[] paritys = new string[] { Parity.None.ToString(), Parity.Odd.ToString(), Parity.Even.ToString(), Parity.Mark.ToString(), Parity.Space.ToString() };
            return paritys;
        }

        private object[] GetDataBits()
        {
            object[] items = new object[] {5,6,7,8 };
            return items;
        }

        private object[] GetRaudRates()
        {
            List<string> items = new List<string>();
            int i;
            //逐个添加
            for (i = 300; i <= 38400; i = i * 2)
            {
                items.Add(i.ToString());  //添加波特率
            }
            //波特率列表
            string[] specRaud = { "43000", "56000", "57600", "115200", "128000", "230400", "256000", "460800" };

            items.AddRange(specRaud);
            return items.ToArray();
        }

        private void ComboPortNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.debugHelper.SerialPortName = this.comboPortNames.SelectedItem.ToString();
        }

        private void ComboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.debugHelper.BaudRate = int.Parse(this.comboBaudRate.SelectedItem.ToString());
        }

        private void ComboDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.debugHelper.DataBits = (int)this.comboDataBits.SelectedItem;
        }

        private void Comboparity_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch(this.comboparity.SelectedItem.ToString())
            {
                case "None":
                    this.debugHelper.parity = Parity.None;
                    break;
                case "Odd":
                    this.debugHelper.parity = Parity.Odd;
                    break;
                case "Even":
                    this.debugHelper.parity = Parity.Even;
                    break;
                case "Mark":
                    this.debugHelper.parity = Parity.Mark;
                    break;
                case "Space":
                    this.debugHelper.parity = Parity.Space;
                    break;
            }
        }

        private void ComboStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboStopBits.SelectedItem.ToString())
            {
                case "1":
                    this.debugHelper.StopBits = StopBits.One;
                    break;
                case "1.5":
                    this.debugHelper.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    this.debugHelper.StopBits = StopBits.Two;
                    break;

            }
        }

        private void BtnSerialPortswitch_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.debugHelper.serialPortIsOpen())
                {


                    this.debugHelper.CloseSerialPort();
                    lblStatus.Text = "串口【" + this.debugHelper.SerialPortName + "】已关闭";
                    this.btnSerialPortswitch.Text = "打开串口";
                    this.btnSerialPortswitch.BackColor = Color.Green;
                    this.comboPortNames.Enabled = true;
                    this.comboBaudRate.Enabled = true;
                    this.comboDataBits.Enabled = true;
                    this.comboparity.Enabled = true;
                    this.comboStopBits.Enabled = true;

                    this.checkAutoSd.Enabled = false;
                    this.numSdInvertal.Enabled = false;
                    this.timer1.Enabled = false;

                }
                else
                {
                    this.debugHelper.OpenSerialPort();
                    lblStatus.Text = "串口【" + this.debugHelper.SerialPortName + "】已打开";
                    this.btnSerialPortswitch.Text = "关闭串口";
                    this.btnSerialPortswitch.BackColor = Color.Red;
                    this.comboPortNames.Enabled = false;
                    this.comboBaudRate.Enabled = false;
                    this.comboDataBits.Enabled = false;
                    this.comboparity.Enabled = false;
                    this.comboStopBits.Enabled = false;

                    this.checkAutoSd.Enabled = true;
                    this.numSdInvertal.Enabled = true;
                    this.timer1.Enabled = this.checkAutoSd.Checked;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClearContent_Click(object sender, EventArgs e)
        {
          
            this.txtBoxRe.Text = string.Empty;
        }

        private void CheckNewLine_CheckedChanged(object sender, EventArgs e)
        {
            this.debugHelper.IsSendEnter = this.checkNewLine.Checked;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.txtBoxSd.Text))
                {
                    this.debugHelper.write(this.txtBoxSd.Text);
                    this.lblSend.Text = "Tx:" + this.debugHelper.SendDataLenght.ToString() + "Bytes";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadioRe_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioReASCII.Checked)
            {
                this.debugHelper.ReviceDataModel = SerialPortDataModel.ASCII;
            }
            if(this.radioReHEX.Checked)
            {
                this.debugHelper.ReviceDataModel = SerialPortDataModel.HEX;
            }
        }

       

        private void RadioSd_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioSdASCII.Checked)
            {
                this.debugHelper.SendDataModel = SerialPortDataModel.ASCII;
            }

            if(this.radioSdHEX.Checked)
            {
                this.debugHelper.SendDataModel = SerialPortDataModel.HEX;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Button3_Click(sender, e);
        }

        private void CheckAutoSd_CheckedChanged(object sender, EventArgs e)
        {
           
                this.timer1.Interval = (int)this.numSdInvertal.Value;
                this.timer1.Enabled = this.checkAutoSd.Checked;
           

        }

        private void NumSdInvertal_ValueChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = (int)this.numSdInvertal.Value;
        }
    }
}
