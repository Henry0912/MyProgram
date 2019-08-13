// ConsoleApplication3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "string.h"

char * EncryptDecrypt(char _input[]) {
	int count = strlen(_input);
	printf("%d \n", count);
	int i = 0;
	for (i = 0; i < count; i++) {
		_input[i] = ~_input[i];
	}
	_input[i] = '\0';

	return _input;
}

int main()
{
	int command = 0;
	char inputString[128] = { '\0' };
	char *tempString;
	while (true)
	{
		printf("Please Enter Command. 1(input)/2(result)/3(exit)\n");
		scanf_s("%d", &command);

		if (command == 1) {
			printf("Please Enter a String to encrypt.\n");
			scanf_s("%s", &inputString, 128);

			tempString = EncryptDecrypt(inputString);
			printf("Encrypted code is %s\n", tempString);
		}
		else if (command == 2) {
			EncryptDecrypt(inputString);
			printf("Decrypted code is %s\n", tempString);
		}
		else if (command == 3) {
			break;
		}
		else {
			continue;
		}

	}

	return 0;
}

