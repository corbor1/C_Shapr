// //  Напишите программу, которая принимает на вход число и проверяет,
// //   кратно ли оно одновременно 7 и 23.
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
//      if (number % 7 == 0 && number % 23 == 0)
//      {
//      Console.WriteLine("Число кратно и 7, и 23.");
//      }
//      else if (number % 7 == 0)
//      {
//      Console.WriteLine("Число кратно только 7.");
//      }
//      else if (number % 23 == 0)
//      {
//      Console.WriteLine("Число кратно только 23.");
//      }
//      else
//      {
//      Console.WriteLine("Число не кратно ни 7, ни 23.");
//      }

//  Console.ReadLine();
// ----------------------------------------
//// координаты точки
// Console.WriteLine("Введите x: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// if ((x > 0) && (y > 0))
//     Console.WriteLine("I четверть");
// else
// {
//     if ((x < 0) && (y > 0))
//         Console.WriteLine("II четверть");
//     else
//     {
//         if ((x < 0) && (y < 0))
//             Console.WriteLine("III четверть");
//         else
//         {
//             if ((x > 0) && (y < 0))
//                 Console.WriteLine("IV четверть");
//             else
//                 Console.WriteLine("Точка лежит на оси");
//         }
//     }
// }
// --------------------------------------------------------
// // Напишите программу, которая принимает на вход 
// // целое число из отрезка [10, 99] и показывает наибольшую цифру числа

// Console.Write("Введите строку:");
// string str = Console.ReadLine();

// int max = int.Parse(str[0].ToString());

// for (int i = 1; i < str.Length; i++)
// {
//     if (max < int.Parse(str[i].ToString()))
//         max = int.Parse(str[i].ToString());
// }
// Console.WriteLine("Наибольшая цифра = " + max);
// Console.ReadKey();
// Console.ReadLine();
// --------------------------------------
Console.Write("Введите n: ");
string a = Console.ReadLine();
long n = Convert.ToInt64(a);
Console.Write("Вывод: ");
if (n == 0)
    Console.Write(n);
else
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a.Length > 9)
        {
            Console.Write("Длина числа превышает допустимую");
            break;
        }
        else
        {
            long rs = n % 10;
            if (rs != 0)
                Console.Write(rs);
            n /= 10;
        }
    }
}