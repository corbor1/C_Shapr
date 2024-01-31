// int[] arr = new int[5];
// arr[0] = 1;
// arr[1] = 3;
// arr[2] = 5;
// arr[3] = 7;
// arr[4] = 4;
// System.Console.WriteLine(arr[0]);
// System.Console.WriteLine(arr[1]);
// System.Console.WriteLine(arr[2]);
// System.Console.WriteLine(arr[3]);
// System.Console.WriteLine(arr[4]);
// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

// int[] arr3 ={5,4,3,2,1};



int n = 10;
int[] arr = new int[n];
int i = 0;
while (i < arr.Length)
{
    arr[i] = i+1;
    // System.Console.WriteLine(arr[i]);
    // System.Console.WriteLine(" ");
    Console.Write($"{arr[i]} ");
    i = i+1;
};