float calcBonus(float sal);
#include <stdio.h>
struct employee
{
    int id;
    char name[20];
    float sal;
    float bonus;
};

int main()
{
	struct employee emp[2];

	for(int i=0; i<2; i++)
    {
        printf("Emp%d ID",i+1);
        scanf("%d",&emp[i].id);

        fflush(stdin);
        printf("Emp%d name",i+1);
        gets(emp[i].name);

        printf("Emp%d salary",i+1);
        scanf("%f",&emp[i].sal);

        emp[i].bonus = calcBonus(emp[i].sal);
    }

    printf("Data\n");
    for(int i=0; i<2; i++)
    {
        printf("Emp%d ID = %d\n",i+1,emp[i].id);

        printf("Emp%d name = ",i+1);
        puts(emp[i].name);

        printf("Emp%d salary = %.2f\n",i+1,emp[i].sal);

        printf("Emp%d Bonus = %.2f\n",i+1,emp[i].bonus);
    }
}

float calcBonus(float sal)
{
    float bonus;
    bonus = sal * 0.3;
    return bonus;
}
