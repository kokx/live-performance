using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSerialConnection
{
    public enum LiftMode
    {
        USER,
        OPERATOR
    }

    public enum MotorState
    {
        LEFT,
        RIGHT,
        IDLE
    }

    public class Lift
    {
        private Connection connection;

        private int verdieping = 0;
        private int hoogte = 0;
        private MotorState motor = MotorState.IDLE;
        private LiftMode modus = LiftMode.USER;

        public int Verdieping
        {
            get
            {
                return Convert.ToInt32(Math.Round(hoogte / 260f));
            }
        }

        public int Hoogte
        {
            get
            {
                return hoogte;
            }
        }

        public MotorState Motor
        {
            get
            {
                return motor;
            }
        }


        public Lift(Connection connection)
        {
            this.connection = connection;

            connection.DataReceived += new EventHandler<ConnectionEventArgs>(connection_DataReceived);
        }

        void connection_DataReceived(object sender, ConnectionEventArgs e)
        {
            if (modus == LiftMode.USER) {
                string message = e.Message;

                if (message.StartsWith("1-")) {
                    message = message.Remove(0, 2);

                    this.verdieping = Convert.ToInt32(message);
                }
            }
        }

        public bool GaNaarVerdieping(int verdieping)
        {
            if (modus == LiftMode.OPERATOR) {
                this.verdieping = verdieping;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Wijzig de modus van de lift
        /// </summary>
        /// <param name="modus">Lift modus</param>
        /// <returns>true</returns>
        public void WijzigModus(LiftMode modus)
        {
            this.modus = modus;
        }

        /// <summary>
        /// Verzend een status update
        /// </summary>
        public void updateStatus()
        {
            // update de hoogte als we aan het verhogen/verlagen zijn
            if (hoogte > verdieping * 260) {
                hoogte -= 2;
                motor = MotorState.LEFT;
            } else if (hoogte < verdieping * 260) {
                hoogte += 2;
                motor = MotorState.RIGHT;
            } else {
                motor = MotorState.IDLE;
            }

            int[] data = new int[3];

            data[0] = Verdieping;
            data[1] = hoogte;

            switch (motor) {
                case MotorState.IDLE:
                    data[2] = 0;
                    break;
                case MotorState.LEFT:
                    data[2] = (1 << 0);
                    break;
                case MotorState.RIGHT:
                    data[2] = (1 << 1);
                    break;
            }

            connection.SendCommand(0, data);
        }
    }
}
