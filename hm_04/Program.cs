﻿
// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Input num: ");

// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i < num)
// {
//    if (i % 2 = 0)
//    {
//       Console.Write(i);
//       i = i + 1;
//    }
// }

Console.Write("Input num: ");

int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < N)
{
   if (i % 2 == 0)
   {
      Console.WriteLine(i);
   }
   i++;

}