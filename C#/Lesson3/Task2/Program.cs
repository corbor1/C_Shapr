void PrintSquare (int limit)
{
    int i=1;
    while (i<=limit)
    {
        System.Console.Write($"{i*i} ");
        i++;
    }
}
PrintSquare(4);
PrintSquare(10);