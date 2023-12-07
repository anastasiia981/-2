// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

using System;
namespace CountEvenNumbers

{
     class Program

    {
       static void Main(string[] args)

        {
          int[] array = new int[]{6, 7, 19, 34, 3, 1, 4, 7, 9, 1};

          int count = 0;
          foreach (int number in array)
          {

                if (number % 2 == 0)
          {

                    count++;
          }
          }

             Console.WriteLine("Количество четных чисел в массиве: " + count);

        }

    }
}
