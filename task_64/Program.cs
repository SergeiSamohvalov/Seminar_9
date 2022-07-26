namespace Homework_9
{
    public class task_64
    // Задайте значения M и N. Напишите программу,
    // которая выведет все натуральные числа в промежутке от M до N.

    {
        static void Main(string[] args)
        {
            Console.Write("Введите M: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите N: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"M={M}, N={N}");
            if (M > N)
                for (int i = N; i <= M; i++)
                    Console.Write($" {i}");
            else
                for (int i = M; i <= N; i++)
                    Console.Write($" {i}");
        }
    }
}