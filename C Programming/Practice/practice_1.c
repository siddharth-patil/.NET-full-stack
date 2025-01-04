//void test();
#include<stdio.h>
#include<conio.h>
//    extern int a;
int main()
{
//    const long int a = 5000L;

//    printf("%d",a);

//    char ch1, ch2, ch3;
//    ch1 = getchar(); //we can see it while typing but it doesn't print on console unless we explicitly print it
//    ch2 = getche(); // we can't see it while typing but just after typing it gets automatically printed on console
//    printf("\n");
//    ch3 = getch(); // we can't see it while typing neither after typing unless we print it explicitly
//    printf("\n");
//
//    putchar(ch1);
//    printf("\n");
//    putchar(ch2);
//    printf("\n");
//    putch(ch3);

//    int a, b;
//    scanf("%2d %4d",&a,&b); // restricts input upto 2 or 4 digits
//    printf("a = %d,  b = %d",a,b);

//    int a=98;
//    int *pa = &a;
//    char *pa = &a;
//
//    printf("%d\n",*pa);
//    printf("%u\n",pa);
//    printf("%d",pa);


//    void test();

//    printf("%c",217);

    for(int i=1; i<=100; i++)
    {
        for(int j=i+1; j<=100; j++)
        {
            for(int k=j+1; k<=100; k++)
            {
                if ((i*i)+(j*j) == (k*k))
                    printf("%d %d %d\n",i,j,k);
            }
        }
    }


    printf("\a");// creates sound

}

//void test()
//{
//    extern int a;
//    printf("%d",a);
//
//}
