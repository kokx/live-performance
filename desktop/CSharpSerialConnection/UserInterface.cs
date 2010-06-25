using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpSerialConnection
{
    public partial class UserInterface : Form
    {
        private SerialPort sPort;

        public UserInterface()
        {
            InitializeComponent();
            sPort = null;
        }

        private void RenesSerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            textBox1.Invoke(
                new EventHandler(
                    delegate 
                    { 
                        textBox1.Text += sPort.ReadExisting().Replace("\n", "\r\n");
                        textBox1.Select(textBox1.Text.Length, 0);
                    }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sPort == null)
            {
                try
                {
                    sPort = new SerialPort("COM1", 38400, Parity.None, 8, StopBits.One);
                    sPort.DataReceived += new SerialDataReceivedEventHandler(RenesSerialDataReceived);
                    sPort.Open();
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show("Creation failed");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("Hi");
                sPort.Write("\n");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sPort != null)
            {
                char[] input = new char[1];
                input[0] = e.KeyChar;
                sPort.Write(input, 0, 1);
            }
        }
    }
}