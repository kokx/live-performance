#include "hal.h"
#include "comm.h"

void showStatus(uint8_t verdieping, uint16_t hoogte, uint8_t motor)
{
    //            "rechtsom     aan", "Hoogte: 100     "
    showScreenLCD("                ", "H:          V:  ");

    setCursorPosLCD(0, 13);
    writeStringLCD_P("aan");

    // motor status
    switch (motor) {
        case MOTOR_IDLE:
            setCursorPosLCD(0, 13);
            writeStringLCD_P("uit");
            break;
        case MOTOR_LEFT:
            setCursorPosLCD(0, 0);
            writeStringLCD_P("Linksom");
            break;
        case MOTOR_RIGHT:
            setCursorPosLCD(0, 0);
            writeStringLCD_P("Rechtsom");
            break;
    }

    setCursorPosLCD(1, 3);
    writeIntegerLCD(hoogte, DEC);

    setCursorPosLCD(1, 15);
    writeIntegerLCD(verdieping, DEC);

    setLEDs(1 << verdieping);
}

uint8_t pressed = false;

void checkButtons(void)
{
    uint8_t key = getPressedKeyNumber();

    char message[10];

    if (key && key < 5) {
        if (!pressed) {
            sprintf(message, "1-%d", key - 1);
            sendMessage(message);

            pressed = true;
        }
    } else {
        pressed = false;
    }
}
