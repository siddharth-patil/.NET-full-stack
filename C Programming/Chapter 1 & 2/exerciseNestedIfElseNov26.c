#include<stdio.h>

int main()
{
    printf("Enter your marks in %%");
    float marks;
    scanf("%f",&marks);

    if(marks>=75)
        printf("Grade A");
    else if (marks>=60)
        printf("Grade B");
    else if(marks>=40)
        printf("Grade C");
    else
        printf("Fail");

    return 1;
}
