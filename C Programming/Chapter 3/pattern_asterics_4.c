int main()
{
    int n;

    printf("Enter number ");
    scanf("%d",&n);


    for(int rows=1; rows<=(n*2-1); rows++)  // rows = n*2-1
    {
        // print spaces -> totalSpaces = n-rows;
        int totalSpaces = rows<=n ? n-rows : rows-n;
        for(int space = 1; space<=totalSpaces; space++)
        {
            printf(" ");
        }

        // print stars -> totalStars = n -(rows-n);
        int totalStars = rows<n ? rows : n-(rows-n);
        for(int j=1; j<=totalStars; j++)
        {

            printf("* ");
        }
        printf("\n");
    }

    return 1;
}
