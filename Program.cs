using System;

namespace Практическая_10._1._1
{
    class Program
    {
        static void Main (string[] args)
        {//18
         //try
         //{
         //    Console.WriteLine("----Введите размеры массива----");
         //    Console.Write("Ширина массива:");
         //    int a = int.Parse(Console.ReadLine());
         //    Console.Write("Высота масива: ");
         //    int b = int.Parse(Console.ReadLine());
         //    if (a > 0 && b > 0)
         //    {
         //        int[,] arr = new int[a, b];
         //        for (int i = 0; i < a; i++)
         //        {
         //            for (int j = 0; j < b; j++)
         //            {
         //                Console.Write($"Элемент : ");
         //                arr[i, j] = int.Parse(Console.ReadLine());
         //            }
         //        }
         //        Console.Write("Введите K: ");
         //        int k = int.Parse(Console.ReadLine());
         //        if (k > 0)
         //        {
         //            Console.Write("Введите K1: ");
         //            int k1 = int.Parse(Console.ReadLine());
         //            Console.Write("Введите K2: ");
         //            int k2 = int.Parse(Console.ReadLine());
         //            int count = 0;
         //            int sum = 0;
         //            for (int i = 0; i < a; i++)
         //            {
         //                for (int j = 0; j < b; j++)
         //                {
         //                    if (arr[i, j] > 0 && arr[i, j] % k == 0)
         //                    {
         //                        count++;
         //                    }
         //                    if (i >= k1 - 1 && i <= k2 - 1)
         //                    {
         //                        sum += arr[i, j];
         //                    }
         //                }
         //            }
         //            Console.WriteLine("----Массив----");
         //            foreach (int element in arr)
         //            {
         //                Console.WriteLine(element + "\t");

            //            }
            //            Console.WriteLine("----Итоги----");
            //            Console.WriteLine($"Колличевство положительных чисел кратных {k}: {count}");
            //            Console.WriteLine($"Сумма чисел в промежутке от {k1} до {k2}:{sum}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("K должно быть больше 0");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Размеры массива не могут быть меньше 0");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Неверный тип данных");
            //}
            //Console.ReadKey();

            //19
            try
            {
                int a, b, n, k1, k2, c = 0, x = 1, m;
                Console.WriteLine("Введите m");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите n");
                n = Convert.ToInt32(Console.ReadLine());
                if (m > 0 && n > 0)
                {
                    Console.WriteLine("Введите a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите b");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите k1");
                    k1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите k2");
                    k2 = Convert.ToInt32(Console.ReadLine());
                    int[,] num = new int[m, n];
                    Random rnd = new Random();
                    for (int i = 0; i < num.GetLength(0); i++)
                    {
                        Console.Write($"Строка {i}|");
                        for (int j = 0; j < num.GetLength(1); j++)
                        {
                            num[i, j] = rnd.Next(-10, 10);
                            Console.Write($"{num[i, j],3}|");
                        }
                        Console.WriteLine();
                    }


                    for (int i = 0; i < num.GetLength(0); i++)
                    {
                        for (int j = 0; j < num.GetLength(1); j++)
                        {

                            if (num[i, j] % a == 0 || num[i, j] % b == 0)
                            {
                                c++;
                            }
                            if (i >= k1 && i <= k2 && num[i, j] < 0)
                            {
                                x *= num[i, j];
                            }



                            Console.WriteLine("Колво  элементов кратных a или b =" + c);
                            Console.WriteLine($"произведение отрицательных элементов элементов из столбцов {k1}-{k2} =" + x);
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Размеры массива не могут быть меньше 0");
                }
            }
            catch
            {
                Console.WriteLine("Неверный тип данных");
            }

        }
    }
}

