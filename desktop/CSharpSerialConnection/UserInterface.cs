using System;
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
        private Connection connection;
        private Lift lift;

        public UserInterface()
        {
            InitializeComponent();

            connection = new Connection();

            connection.DataReceived += new EventHandler<ConnectionEventArgs>(connection_DataReceived);

            lift = new Lift(connection);
        }

        void connection_DataReceived(object sender, ConnectionEventArgs e)
        {
            // we're using invoke, since it looks like this event
            // will be triggered from another thread
            textBox1.Invoke(
                new EventHandler(
                    delegate
                    {
                        textBox1.Text += e.Message;
                    }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Send("test");
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            lift.updateStatus();
        }
    }
}