﻿namespace Homework_9
{
    public class task_66
    // Задайте значения M и N. Напишите программу,
    // которая найдёт сумму натуральных элементов в промежутке от M до N.
    {
        static void Main(string[] args)
        {
            int rez = 0;
            Console.Write("Введите M: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите N: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"M={M}, N={N}");
            Console.WriteLine();
            if (M > N)
            {
                for (int i = N; i <= M; i++)
                {
                    rez += i;
                    Console.Write($" {i}");
                }
            }
            else
            {
                for (int i = M; i <= N; i++)
                {
                    rez += i;
                    Console.Write($" {i}");
                }
            }
            Console.WriteLine();
            Console.Write($"Сумма натуральных элементов в заданном промежуке = {rez}");
        }
    }
}
