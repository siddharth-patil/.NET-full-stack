void displayRainfall(float rain);

#include<stdio.h>

int main()
{
    float rainfall[7] = {23.4, 4, 45, 54.5, 12, 23, 10.34};

    for(int i=0; i<7; i++)
    {
        displayRainfall(rainfall[i]);
    }

    return 1;
}

displayRainfall(float rain)
{
    printf("%.2f mm\n",rain);
}
