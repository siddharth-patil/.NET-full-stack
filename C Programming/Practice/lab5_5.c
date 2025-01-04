#include<stdio.h>

int main()
{
    printf("DATA TYPE \t SIZE\t\t FORMAT SPECIFIER\t range");
    printf("\n char \t\t - size = %d \t %%c \t\t ",sizeof(char));
    printf("\n int \t\t - size = %d \t %%d \t\t %d to %d",sizeof(int),-111111111111111111111,111111111111111111111);
    printf("\n float \t\t - size = %d \t %%f \t\t %f",sizeof(float));
    printf("\n double \t - size = %d \t %%lf",sizeof(double));
    printf("\n long int  \t - size = %d \t %%i",sizeof(long int));
    printf("\n long double \t - size = %d \t %%lf",sizeof(long double));

    printf("\n\r");

    return 1;
}
