char gradeFun(int rollNum, float Marks);
#include<stdio.h>

int main()
{
    printf("Enter roll number: ");
    int rollNum;
    scanf("%d",&rollNum);

    printf("Enter aggregate marks: ");
    float aggrMarks;
    scanf("%f",&aggrMarks);

    char grade = gradeFun(rollNum, aggrMarks);
    printf("Your grade is %c",grade);
}

char gradeFun(int rollNum, float Marks)
{
    char grade;
    if(Marks>90)
        grade = 'A';
    else if(Marks>75 && Marks<=90)
        grade = 'B';
    else if(Marks>60 && Marks<=75)
        grade = 'C';
    else
        grade = 'D';

    return grade;
}
