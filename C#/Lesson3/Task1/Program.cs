double calculate(int a, int b, int c, int d)
{
    double ab = a * b;
    int cd = c + d;
    double result = ab / cd;
    return result;
}

double result = calculate(1, 2, 3, 4);
System.Console.WriteLine(result);