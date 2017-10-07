using System;

namespace two_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            int n1 = 0, n2 = 0;
            Random rnd = new Random();

            Console.Write("Введите кол-во строк (кол-во строк и столбцов одинаково): ");

            try
            {
                n1 = Int32.Parse(Console.ReadLine());
                n2 = n1;
                float[,] m = new float[n1, n2];

                Console.WriteLine("1 : Случайный ввод");
                Console.WriteLine("2 : Ручной ввод");

                switch (Int32.Parse(Console.ReadLine()))
                {
                    case 1:
                        for (i = 0; i <= n1 - 1; i++)
                        {
                            for (j = 0; j <= n2 - 1; j++)
                            {
                                m[i, j] = rnd.Next(-100, 100);
                            }
                        }
                        break;
                    case 2:
                        for (i = 0; i <= n1 - 1; i++)
                        {
                            for (j = 0; j <= n2 - 1; j++)
                            {
                                Console.Write("Введите элемент M[" + (i + 1) + "," + (j + 1) + "]: ");
                                m[i, j] = float.Parse(Console.ReadLine());
                            }
                        }
                        break;
                }

                for (i = 0; i <= n1 - 1; i++)
                {
                    Console.WriteLine();
                    for (j = 0; j <= n2 - 1; j++)
                    {
                        Console.Write(" " + m[i, j] + "\t");
                    };
                }

                Console.WriteLine();

                float sum = 0, isum = 0;

                for (j = 0; j <= n1 - 1; j++)
                {
                    sum = 0; isum = 0;
                    for (i = 0; i <= n2 - 1; i++)
                    {
                        if (m[i, j] < 0)
                            isum++;
                    }
                    if (isum == 0)
                    {
                        for (i = 0; i <= n2 - 1; i++)
                            sum = sum + m[i, j];
                        Console.WriteLine("Сумма столбца №" + (j + 1) + " = " + sum);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("В столбце №" + (j + 1) + " есть отрицательный элемент");
                        Console.WriteLine();
                    }
                }

                int k = 0;
                float sume = m[0, 0];
                float s = n1;

                for (k = 0; k <= n1 - 1; k++)
                {
                    if (sume < s)
                    {
                        s = sume;
                    }
                    sume = 0;

                    for (i = 0; i <= n1 - 1; i++)
                    {
                        sume = sume + Math.Abs(m[i, (i + k) - i]);
                    }
                }
                Console.Write("Минимумум среди модулей сумм побочных диагоналей равен: " + s);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

