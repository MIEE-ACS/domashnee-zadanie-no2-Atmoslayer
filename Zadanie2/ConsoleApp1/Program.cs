using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Печать значений y для x [-3,7]");
            Automatic();
            Manual();
        }

        private static void Manual()
        {
            Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -");
            double x, y, R1, R2;
            int operation;

            while (true)
            {

                Console.WriteLine("Вывод значение y для введённого Вами значения x\n");
                Console.WriteLine("Чтобы ввести значение, нажмите 1...............\n");
                Console.WriteLine("Чтобы выйти из программы, нажмите 0............\n");
                string stroperation = Console.ReadLine();
                operation = Convert.ToInt32(stroperation);

                switch (operation)
                {
                    case 0:

                        Environment.Exit(0);
                        break;

                    case 1:


                        {
                            Console.WriteLine("Введите значение x: ");
                            string str = Console.ReadLine();
                            x = Convert.ToDouble(str);


                            if (-3 <= x && Math.Round(x, 3) <= -2)
                            {
                                Console.WriteLine("Значение y: ");
                                Liner1(x);
                            }

                            if (Math.Round(x, 3) > -2 && Math.Round(x, 3) <= 0)
                            {
                                Console.WriteLine("На графике присутствует полуокружность, введите её радиус");
                                string str1 = Console.ReadLine();
                                R1 = Convert.ToDouble(str1);
                                Console.WriteLine("Значение y: ");
                                Rounder1(x, R1);
                            }

                            if (0 < x && Math.Round(x, 3) <= 4)
                            {
                                Console.WriteLine("На графике присутствует полуокружность, введите её радиус");
                                string str2 = Console.ReadLine();
                                R2 = Convert.ToDouble(str2);
                                Console.WriteLine("Значение y: ");
                                Rounder2(x, R2);
                            }

                            if (4 < x && Math.Round(x, 3) <= 6)
                            {
                                Console.WriteLine("Значение y: ");
                                Liner2(x);
                            }

                            if (6 < x && Math.Round(x, 3) <= 7)
                            {
                                Console.WriteLine("Значение y: ");
                                Liner3(x);
                            }

                            if (x < -3)
                            {
                                Console.WriteLine("Значение y: ");
                                y = 1;
                                Console.WriteLine(Math.Round(y, 3));
                            }

                            if (x > 7)
                            {
                                Console.WriteLine("Значение y: ");
                                y = -1;
                                Console.WriteLine(Math.Round(y, 3));
                            }

                        }
                        break;
                }
            }
        }

        private static void Automatic()
        {
            double x, y, R1, R2;

            Console.WriteLine("На графике присутствуют полуокружности, введите радиус первой окружности");
            string str1 = Console.ReadLine();
            R1 = Convert.ToDouble(str1);
            Console.WriteLine("Введите радиус второй окружности");
            string str2 = Console.ReadLine();
            R2 = Convert.ToDouble(str2);


            Console.WriteLine("Значения функции:");

            for (x = -3; x <= 7; x = x + 0.2)
            {
                if (-3 <= x && Math.Round(x, 3) <= -2)
                {
                    Liner1(x);
                }

                if (Math.Round(x, 3) > -2 && Math.Round(x, 3) <= 0)
                {
                    Rounder1(x, R1);
                }
                if (0 < x && Math.Round(x, 3) <= 4)
                {
                    Rounder2(x, R2);
                }
                if (4 < x && Math.Round(x, 3) <= 6)
                {
                    Liner2(x);
                }
                if (6 < x && Math.Round(x, 3) <= 7)
                {
                    Liner3(x);
                }
            }
        }

        static void Liner1(double x)
        {
            double y = -x - 2;
            Console.WriteLine(Math.Round(y, 3));
        }
        static void Liner2(double x)
        {
            double y = -0.5 * x + 2;
            Console.WriteLine(Math.Round(y, 3));
        }
        static void Liner3(double x)
        {
            double y = -1;
            Console.WriteLine(Math.Round(y, 3));
        }
        static void Rounder1(double x, double R)
        {
            double y;
            if (R >= 1)
            {
                R = 1;
                y = Math.Sqrt(Math.Abs(R * R - (x + 1) * (x + 1)));
                Console.WriteLine(Math.Round(y, 3));
            }
            if (R < 1)
            {
                if (Math.Round(x, 3) < -1 - R)
                {
                    Console.WriteLine("н/д");
                }

                if (Math.Round(x, 3) > -1 + R && Math.Round(x, 3) < 0)
                {
                    Console.WriteLine("н/д");
                }
                if (Math.Round(x, 3) >= -1 - R && Math.Round(x, 3) <= -1 + R)
                {
                    y = Math.Sqrt(Math.Abs(R * R - (x + 1) * (x + 1)));
                    Console.WriteLine(Math.Round(y, 3));
                }   
            }
        }
        static void Rounder2(double x, double R)
        {
            double y;
            if (R >= 2)
            {
                R = 2;
                y = -Math.Sqrt(Math.Abs(R * R - (x - 2) * (x - 2)));
                Console.WriteLine(Math.Round(y, 3));
            }
            if (R < 2)
            {
                if (Math.Round(x, 3) < 2 - R)
                {
                    Console.WriteLine("н/д");
                }

                if (Math.Round(x, 3) > 2 + R && Math.Round(x, 3) < 4)
                {
                    Console.WriteLine("н/д");
                }
                if (Math.Round(x, 3) >= 2 - R && Math.Round(x, 3) <= 2 + R)
                {
                    y = -Math.Sqrt(Math.Abs(R * R - (x - 2) * (x - 2)));
                    Console.WriteLine(Math.Round(y, 3));
                }
            }
        }
    }
}
