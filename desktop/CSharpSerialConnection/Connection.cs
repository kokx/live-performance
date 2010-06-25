using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Text;

namespace CSharpSerialConnection
{
    public class ConnectionEventArgs : EventArgs
    {
        private string message;

        public string Message
        {
            get
            {
                return message;
            }
        }

        public ConnectionEventArgs(string message)
        {
            this.message = message;
        }
    }

    public class Connection
    {
        private SerialPort sPort;

        public event EventHandler<ConnectionEventArgs> DataReceived;

        public Connection()
        {
            sPort = null;
        }

        private void RenesSerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ConnectionEventArgs args = new ConnectionEventArgs(sPort.ReadExisting().Replace("\n", "\r\n"));

            DataReceived(this, args);
        }

        public void Connect()
        {
            if (sPort == null) {
                sPort = new SerialPort("COM1", 38400, Parity.None, 8, StopBits.One);
                sPort.DataReceived += new SerialDataReceivedEventHandler(RenesSerialDataReceived);
                sPort.Open();
            }
        }

        public void Send(string data)
        {
            if (sPort != null) {
                sPort.Write(data + "\n");
            }
        }

        public void SendCommand(int command, int[] data)
        {
            string send = command.ToString();

            foreach (int part in data) {
                send += "-" + part.ToString();
            }

            this.Send(send);
        }
    }
}
