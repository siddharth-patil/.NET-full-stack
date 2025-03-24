// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = new int[] {2,7,5,11};
int target = 9;
int outerLen = nums.Length - 2;
int innerLen = outerLen + 1;
int[] arr = new int[5];
int k = 0;
for (int j = 0; j <= outerLen; j++)
{
    for (int i = j + 1; i <= innerLen; i++)
    {
        if ((nums[j] + nums[i]) == target)
        {
            arr[k] = j;
            k++;
            arr[k] = i;
            k++;
        }
    }
}
for (int i = 0; i < arr.Length-1; i++)
{
    Console.WriteLine(arr[i]);
}
