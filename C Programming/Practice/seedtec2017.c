#include <stdio.h>

#include <string.h>



int main()

{

    struct xyz{

        char * n;

        int eos;

    };



        struct xyz x = {"seedtec", 201567};

        struct xyz y=x;

        int p = printf("%s",y.n);

        printf("\n%d\n",p);

        int b = printf("%d",y.eos);

        printf("\n%d\n",b);

        int v = scanf("%d %d",&y.eos,&b);

        printf("\n%d\n",v);

        printf("%d", printf("%s",y.n));



        return 0;

}
