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

            //connection.DataReceived += new EventHandler<ConnectionEventArgs>(connection_DataReceived);

            lift = new Lift(connection);
        }

        /*void connection_DataReceived(object sender, ConnectionEventArgs e)
        {
            // we're using invoke, since it looks like this event
            // will be triggered from another thread
            textBox1.Invoke(
                new EventHandler(
                    delegate
                    {
                        textBox1.Text += e.Message;
                    }));
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Connect();

            statusTimer.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Send("test");
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            lift.updateStatus();

            verdieping.Value = lift.Verdieping;

            height.Value = lift.Hoogte;

            switch (lift.Motor) {
                case MotorState.IDLE:
                    motor.Text = "uit";
                    break;
                case MotorState.LEFT:
                    motor.Text = "Linksom   aan";
                    break;
                case MotorState.RIGHT:
                    motor.Text = "Rechtsom  aan";
                    break;
            }
        }

        private void control_CheckedChanged(object sender, EventArgs e)
        {
            if (control.Checked) {
                lift.WijzigModus(LiftMode.OPERATOR);

                ver0.Enabled = true;
                ver1.Enabled = true;
                ver2.Enabled = true;
                ver3.Enabled = true;
            } else {
                lift.WijzigModus(LiftMode.USER);

                ver0.Enabled = false;
                ver1.Enabled = false;
                ver2.Enabled = false;
                ver3.Enabled = false;
            }
        }

        private void ver3_CheckedChanged(object sender, EventArgs e)
        {
            lift.GaNaarVerdieping(3);
        }

        private void ver2_CheckedChanged(object sender, EventArgs e)
        {
            lift.GaNaarVerdieping(2);
        }

        private void ver1_CheckedChanged(object sender, EventArgs e)
        {
            lift.GaNaarVerdieping(1);
        }

        private void ver0_CheckedChanged(object sender, EventArgs e)
        {
            lift.GaNaarVerdieping(0);
        }
    }
}