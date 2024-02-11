// //Пример таботы с IF оператор Да или нет
// int a = 9;
// int b = 1;
// int c = 2;
// int d = 8;
// int e = 10;
// int f = 60;
// int max = a;
// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// if (d > max)
// {
//     max = d;
// }
// if (e > max)
// {
//     max = e;
// }
// if (f > max)
// {
//     max = f;
// }
// System.Console.WriteLine(max);





// int n = 10;
// int i = 1;
// while (i<=n)
// {
//     Console.Write($" {i}");
//     i++;
// }


// Задание 3. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// int a = 100;
// int b = 10;
// int rem = a % b;
// if (rem == 0)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine($"Нет {rem}");
// }



// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет
// int a = 456789;
// int b = a % 10;

// if (a > 99)
// {

//     System.Console.WriteLine($"{a / 100%10}");

// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }

// int[] arr = {1, 3, 4, 19, 3};
// int a = 8;
// bool inArray = false;

/*for(int i = 0; i<arr.Length;i++)
{
    if(a == arr[i])
    {
        inArray = true;
        //System.Console.WriteLine("Да");
    }
    
}*/







foreach(int i in arr)
{
    if(a == i)
    {
        inArray = true;
    }
}

if(inArray)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}




// Задание 1. Совместная работа
// Семинар 3. Массивы
// 15 мин
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// int[] arr = {1, 3, 4, 19, 3};
// int a = 8;
// bool inArray = false;

// for(int i = 0; i<arr.Length;i++)      
// {
//     if(a == arr[i])
//     {
//         inArray = true;
//         //System.Console.WriteLine("Да");
//     }
    
// }

// foreach(int i in arr)
// {
//     if(a == i)
//     {
//         inArray = true;
//     }
// }

// if(inArray)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }

// ---------------------------------------------
// Задание 1. Совместная работа
// Семинар 5. Двумерные массивы
// 15 мин
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4

// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

// void ChangeArray (int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i %2 == 0 && j %2 == 0 && i == j)
//             {
//                 matrix[i, j] *= matrix[i, j];
//             }
//         }
//     }
// } 

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             //Console.Write($"{matrix[i, j],-4}");
//             Console.Write($"{matrix[i, j]:d2}  ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int [,] matrix =
// {
//     {2, 3, 4, 3, 4},
//     {1, 7, 9, 10, 5},
//     {6, 4, 5, 1, 7}
// };
// PrintMatrix(matrix);
// ChangeArray(matrix);
// PrintMatrix(matrix);