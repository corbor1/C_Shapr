int n = 10;
int[] arr = { 2, 8, 92, 4, 2, 1, 45, 62, 12, 10 };
int i = 0;

while (i < n)
{
    if (arr[i] % 2 == 0)
    {
        System.Console.Write($"{arr[i]} ");
    }
    i = i+1;
}