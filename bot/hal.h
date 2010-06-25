#ifndef _HAL_H_
#define _HAL_H_

    /* includes */
    #include "RP6ControlLib.h"

    /* defines */
    #define MOTOR_IDLE  0
    #define MOTOR_LEFT  1
    #define MOTOR_RIGHT 2

    /* function prototypes */
    void showStatus(uint8_t verdieping, uint16_t hoogte, uint8_t motor);
    void checkButtons(void);

#endif
