//Scanner
// COMPILE:  "gcc -o main main.c -lnfc"

#include <stdlib.h>
#include <nfc/nfc.h>
#include <stdio.h>
#include <unistd.h>
#include <time.h>

static void print_hex(const uint8_t *pbtData, const size_t szBytes) {
    size_t szPos;

    for (szPos = 0; szPos < szBytes; szPos++) {
        printf("%02x  ", pbtData[szPos]);
    }
    printf("\n");
}

int main(int argc, const char *argv[]) {
    nfc_device *pnd;
    nfc_target nt;

    // Allocate only a pointer to nfc_context
    nfc_context *context;

    // Initialize libnfc and set the nfc_context
    nfc_init(&context);
    if (context == NULL) {
        printf("Unable to init libnfc (malloc)\n");
        exit(EXIT_FAILURE);
    }

    // Display libnfc version
    const char *acLibnfcVersion = nfc_version();
    (void) argc;
    printf("%s uses libnfc %s\n", argv[0], acLibnfcVersion);

    // Open, using the first available NFC device which can be in order of selection:
    //   - default device specified using environment variable or
    //   - first specified device in libnfc.conf (/etc/nfc) or
    //   - first specified device in device-configuration directory (/etc/nfc/devices.d) or
    //   - first auto-detected (if feature is not disabled in libnfc.conf) device
    pnd = nfc_open(context, NULL);

    if (pnd == NULL) {
        printf("ERROR: %s\n", "Unable to open NFC device.");
        exit(EXIT_FAILURE);
    }
    // Set opened NFC device to initiator mode
    if (nfc_initiator_init(pnd) < 0) {
        nfc_perror(pnd, "nfc_initiator_init");
        exit(EXIT_FAILURE);
    }

    // Poll for a ISO14443A (MIFARE) tag
    const nfc_modulation nmMifare = {
            .nmt = NMT_ISO14443A,
            .nbr = NBR_106,
    };

    char str[] = "s000000000000";   //UID = 20 bestehend aus s + 12 Nullern + NFC-Code
    FILE *fp;
    //change to Client or ClientVertrag
    fp = fopen("/home/pi/ClientVertrag/Files/UID.txt", "w"); //w=Creates an empty file, and erases content if exists

    if (nfc_initiator_select_passive_target(pnd, nmMifare, NULL, 0, &nt) > 0) {
    fwrite(str, 1, sizeof(str) - 1, fp);
        for (int i = 3; i >= 0; i--) {
            fprintf(fp, "%02X", nt.nti.nai.abtUid[i]);
        }
    }
    // Close NFC device
    nfc_close(pnd);
    // Release the context
    nfc_exit(context);
    exit(EXIT_SUCCESS);
}
