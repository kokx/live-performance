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
    public partial class Form1 : Form
    {
        private SerialPort sPort;

        public Form1()
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
                        textBox1.Text += sPort.ReadExisting();
                        textBox1.Select(textBox1.Text.Length, 0);
                    }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sPort == null)
            {
                try
                {
                    sPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
                    sPort.DataReceived += new SerialDataReceivedEventHandler(RenesSerialDataReceived);
                    sPort.Open();
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Creation failed");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sPort != null)
            {
                sPort.Write("Hallo");
                sPort.Write("\0");
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