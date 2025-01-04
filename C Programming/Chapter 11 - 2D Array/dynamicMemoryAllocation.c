#include<stdio.h>
#include<stdlib.h>
#include<string.h>

int main()
{
    char name[20];
	char *pName;

	printf("Enter Name ");
	gets(name);

	pName = (char*) malloc(strlen(name) + 1);

	strcpy(pName,name);

	puts(pName);
	free(pName);

	return 0;
}
