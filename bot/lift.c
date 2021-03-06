/**
* RP6 control for the elevator
* 
* Written by Pieter Kokx
*/

#include "RP6ControlLib.h"

#include "comm.h"
#include "hal.h"

// states
#define STATE_IDLE 0

/*
 * Give the user an elevatorish welcome
 */
void welcome(void)
{
    setLEDs(0b1111); // Turn all LEDs on!

    showScreenLCD("################", "################");
    mSleep(500);
    showScreenLCD("Elevator", "Initializing");
    mSleep(1000);
    // ---------------------------------------
    setLEDs(0b0000); // All LEDs off!
}

uint8_t temp;
uint16_t tempLong;

char * parseLongNumber(char *cp)
{
    char number[10];
    uint8_t i;

    for (uint8_t i = 0; (*(++cp) != '-') && (*cp != '\0'); i++) {
        number[i] = *cp;
    }

    tempLong = atoi(number);

    return cp;
}

char * parseNumber(char *cp)
{
    char number[4];
    uint8_t i;

    for (uint8_t i = 0; (*(++cp) != '-') && (*cp != '\0'); i++) {
        number[i] = *cp;
    }

    temp = atoi(number);

    return cp;
}

// this method is not safe yet
void parseCommand(char *command)
{
    switch (*command) {
        case '0':
            // status command
            command++;

            if (*command != '-') {
                return;
            }

            // eerst de verdieping
            command = parseNumber(command);

            uint8_t verdieping = temp;

            if (*command != '-') {
                return;
            }

            // note that the height will probably be a 16-bit integer later
            // hoogte
            command = parseLongNumber(command);

            uint16_t hoogte = tempLong;

            if (*command != '-') {
                return;
            }

            command = parseNumber(command);

            uint8_t motor = temp;

            showStatus(verdieping, hoogte, motor);
            break;
    }
}

int main(void)
{
    initRP6Control();
    initLCD();

    welcome();

    char * message;

    while (true) {
        message = receiveMessage();
        parseCommand(message);

        checkButtons();
    }
    return 0;
}
