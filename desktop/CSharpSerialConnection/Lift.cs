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

        public Lift(Connection connection)
        {
            this.connection = connection;
        }

        public bool gaNaarVerdieping(int verdieping)
        {
            throw NotImplementedException();
        }

        /// <summary>
        /// Wijzig de modus van de lift
        /// </summary>
        /// <param name="modus">Lift modus</param>
        /// <returns>true</returns>
        public bool wijzigModus(LiftMode modus)
        {
            throw NotImplementedException();
            this.modus = modus;

            return true;
        }

        /// <summary>
        /// Verzend een status update
        /// </summary>
        public void updateStatus()
        {
            int[] data = new int[3] ;

            data[0] = verdieping;
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
