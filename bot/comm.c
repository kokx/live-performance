#include "comm.h"

// max message lenght
#define MAX_LEN 20

char buffer[MAX_LEN + 1];

char * receiveMessage(void)
{
    if (getBufferLength() > 0) {
        uint8_t i = 0;

        // loop until we have an entire line
        while (true) {
            if (getBufferLength() > 0) {
                buffer[i] = readChar();

                if (buffer[i] == '\n') { // EOL
                    // terminate string
                    buffer[i] = '\0';

                    break;
                } else if (i >= MAX_LEN) {
                    buffer[MAX_LEN] = '\0';

                    break;
                }
                i++;
            }
        }

        return buffer;
    }
    return NULL;
}

void sendMessage(char *message)
{
    writeString(message);
}
