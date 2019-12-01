using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace COMLIB
{
    public class SerialPortDebugHelper
    {
        /// <summary>
        /// 串口
        /// </summary>
        private SerialPort serialPort;


        public event SerialDataReceivedEventHandler onSerialDataReceiveData;

        

        /// <summary>
        /// 串口名称
        /// </summary>
        public string SerialPortName { get; set; }
        /// <summary>
        /// 停止位
        /// </summary>
        public StopBits StopBits { get; set; }
        /// <summary>
        /// 串行波特率
        /// </summary>
        public int BaudRate { get; set; }
        /// <summary>
        /// 发信息数据模式
        /// </summary>
        public SerialPortDataModel SendDataModel { get; set; }
        /// <summary>
        /// 收信息数据模式
        /// </summary>
        public SerialPortDataModel ReviceDataModel { get; set; }

        /// <summary>
        /// 发送字节数
        /// </summary>
        public int SendDataLenght { get; set; }
        /// <summary>
        /// 接收字节数
        /// </summary>
        public int ReviceDataLenght { get; set; }

        /// <summary>
        /// 数据位
        /// </summary>
        public int DataBits { get; set; }

        /// <summary>
        /// 校验位
        /// </summary>
        public Parity parity { get; set; }


        /// <summary>
        /// 当前回传内容
        /// </summary>
        public StringBuilder ReviceDataContent { get; set; }

        /// <summary>
        /// 发送是否换行
        /// </summary>
        public bool IsSendEnter { get; set; }
        public SerialPortDebugHelper(SerialPort serialPort)
        {
            this.serialPort = serialPort;
            this.serialPort.DataReceived += SerialPort_DataReceived;
            this.ReviceDataContent = new StringBuilder();
        }

        public void OpenSerialPort()
        {
            if (this.serialPort == null)
                throw new Exception("串口为空");
            if (this.serialPort.IsOpen)
                return;
            else
            {
                this.serialPort.PortName = this.SerialPortName;
                this.serialPort.StopBits = this.StopBits;
                this.serialPort.BaudRate = this.BaudRate;
                this.serialPort.DataBits = this.DataBits;
                this.serialPort.Parity = this.parity;
                this.serialPort.Open();
            }
        }

        public void CloseSerialPort()
        {
            if (this.serialPort == null)
                throw new Exception("串口为空");
            if(this.serialPort.IsOpen)
            {
                this.serialPort.Close();
            }

        }
        public bool serialPortIsOpen()
        {
            if (this.serialPort == null)
                return false;
            return this.serialPort.IsOpen;
        }

        public void write(string content)
        {
            if(SendDataModel==SerialPortDataModel.ASCII)
            {
                writeASCII(content);
            }
            if(SendDataModel==SerialPortDataModel.HEX)
            {
                writeHEX(content);
            }
        }

        private void writeHEX(string content)
        {

            string partten = @"\s";
            string replacecontent = "";
            string tempcontent = Regex.Replace(content, partten, replacecontent);
            int num = tempcontent.Length / 2;
            byte[] buffer = new byte[1];
            for (int i = 0; i < num; ++i)
            {
                buffer[0] = Convert.ToByte(tempcontent.Substring(i * 2, 2), 16);
                this.serialPort.Write(buffer, 0, 1);
            }
            if (tempcontent.Length % 2 == 1)
            {
                buffer[0] = Convert.ToByte(tempcontent.Substring(num * 2, 1), 16);
                this.serialPort.Write(buffer, 0, 1);
                num++;
            }

            if (IsSendEnter)
            {
                this.serialPort.WriteLine("");
            }
            this.SendDataLenght += num;

        }
        private void writeASCII(string content)
        {
            int num;
            if(IsSendEnter)
            {
                num = content.Length + 2;
                this.serialPort.WriteLine(content);
            }
            else
            {
                num = content.Length;
                this.serialPort.Write(content);
            }
            this.SendDataLenght += num;
             
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            Read((SerialPort)sender);

            if (onSerialDataReceiveData != null)
                onSerialDataReceiveData(sender, e);
        }

        private void Read(SerialPort serialPort)
        {
           if(this.ReviceDataModel==SerialPortDataModel.ASCII)
            {
                ReadASCII(serialPort);
            }
           else
            {
                ReadHEX(serialPort);
            }
        }

        private void ReadHEX(SerialPort serialPort)
        {
            int num = serialPort.BytesToRead;
            byte[] buffer = new byte[num];
            ReviceDataLenght += num;

            serialPort.Read(buffer, 0, num);

            ReviceDataContent.Clear();

            foreach(byte val in buffer)
            {
                ReviceDataContent.Append(val.ToString("X2") + ' ');
            }

        }




        private void ReadASCII(SerialPort serialPort)
        {
            int num = serialPort.BytesToRead;
            ReviceDataLenght += num;
            byte[] buffer = new byte[num];
            serialPort.Read(buffer, 0, num);
            ReviceDataContent.Clear();

            ReviceDataContent.Append(Encoding.ASCII.GetString(buffer));
        }

      


    }
    public enum SerialPortDataModel { ASCII,HEX}
}
