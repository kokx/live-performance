/**
* RP6 control for the elevator
* 
* Written by Pieter Kokx
*/

#include "RP6ControlLib.h"

#include "comm.h"
#include "hal.h"

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

int main(void)
{
    initRP6Control();
    initLCD();

    welcome();

    while (true) {
    }
    return 0;
}
