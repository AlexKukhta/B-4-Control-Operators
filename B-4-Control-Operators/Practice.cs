using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {
            Console.WriteLine(DateTime.Today.TimeOfDay);
            var day = DateTime.Today.TimeOfDay;

            if (day.Hours > 0 && day.Hours < 12)
            {
                Console.WriteLine("Good moning, Olga");
            }

            else if (day.Hours > 12 && day.Hours < 17)
            {
                Console.WriteLine("Good day, Olga");
            }
            else
            {
                Console.WriteLine("Good evening, Olga");
            }
        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            Console.WriteLine("Алгоритм сравнения двух чисел");
            Console.WriteLine("Введите число Х: ");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            if (X == Y)
            {
                Console.WriteLine("Значения равны");
            }
            else if (X > Y)
                Console.WriteLine("Значение Х больше Y на {0}", X - Y);

            else
                Console.WriteLine("Значение Y больше X на {0}", Y - X);

            Console.ReadKey();
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            Console.WriteLine("Алгоритм сравнения двух чисел");
            Console.WriteLine("Введите число Х: ");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число Y: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            if (X >= 0 && Y >= 0)
            {
                if (X == Y)
                {
                    Console.WriteLine("Значения равны");
                }
                else if (X > Y)
                {
                    Console.WriteLine("Значение Х больше Y на {0}", X - Y);
                }

                else
                {
                    Console.WriteLine("Значение Y больше X на {0}", Y - X);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели отрицательное число");
            }

            Console.ReadKey();
        }


        //B4-P4/25. If_Akinator5Numbers 
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            Console.WriteLine("Acinator from 1 till 5\n");

            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Вы загадали число 1");
            }
            else if (x == 2)
            {
                Console.WriteLine("Вы загадали число 2");
            }
            else if (x == 3)
            {
                Console.WriteLine("Вы загадали число 3");
            }
            else if (x == 4)
            {
                Console.WriteLine("Вы загадали число 4");
            }
            else if (x == 5)
            {
                Console.WriteLine("Вы загадали число 5");
            }
            else
            {
                Console.WriteLine("не угадали");
            }
            Console.ReadKey();
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
            var today = DateTime.Today;
            var dayOfWeek = (int)today.DayOfWeek;
            switch (dayOfWeek - 1)
            {
                case 0:
                    Console.WriteLine("Доброго понедельника, Ольга");
                    break;
                case 1:
                    Console.WriteLine("Доброго вторника, Ольга");
                    break;
                case 2:
                    Console.WriteLine("Доброй среды, Ольга");
                    break;
                case 3:
                    Console.WriteLine("Доброго четверга, Ольга");
                    break;
                case 4:
                    Console.WriteLine("Доброй пятницы, Ольга");
                    break;
                case 5:
                    Console.WriteLine("Доброй субботы, Ольга");
                    break;
                case 6:
                    Console.WriteLine("Доброго воскресенья, Ольга");
                    break;
            }
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            var buttom = Console.ReadKey();

            switch (buttom.KeyChar)
            {
                case 'W':
                case 'w':
                    Console.WriteLine("Вверх");
                    break;
                case 'S':
                case 's':
                    Console.WriteLine("Низ");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Лево");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Право");
                    break;
                default:
                    Console.WriteLine("Куда прешь?");
                    break;
            }
            Console.ReadLine();
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            Console.WriteLine("Output numbers from 1 till 10");

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even numbers");
                }
                else
                {
                    Console.WriteLine("Add numbers");
                }
            }
            Console.ReadKey();
        }

        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            Console.WriteLine("30 DevideNumbers");

            for (int i = 30; i > 0; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Число {0} делится без остатка на 3", i);
                }
            }

            Console.ReadLine();
        }

        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
            Console.WriteLine("Matrix 10x10");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(i + j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Hello world!");
            }
            Console.ReadKey();
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            Console.WriteLine("10 Afrochildren");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("{i} afrochildren", i);
            }
            Console.ReadKey();
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
            Console.WriteLine("For_Minus10");
            for (int i = 0; i >= -10; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Число четное");
                }
                else
                    Console.WriteLine("Число нечетное");
            }
            Console.ReadKey();
        }


        //B4-P13/25 For_LettersCount
        public static void b4_p13_25_for_letterscount()
        {
            Console.WriteLine("Введите слово:");
            string word = Convert.ToString(Console.ReadLine());
            int x = word.Length;
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    counter++;
                }
            }
            Console.WriteLine("Количество букв 'а' в слове {0} равно {1}", word, counter);
            Console.ReadLine();
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            for (var i = 0x007A; i >= 0x0041; i--)
            {
                Console.WriteLine(Convert.ToChar(i));
            }

            Console.ReadLine();
        }


        //B4-P15/25 While_OddEventNumber
        public static void b4_p15_25_while_oddeventnumber()
        {
            int n;
            int a = 0;
            while (a < n)
            {
                if (a % 2 == 0 && a < n)
                {
                    Console.WriteLine("{0} четные числа", a);
                }
                a++;

            }

            Console.ReadKey();
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
            int N;
            int a = 0;
            while (a < N)
            {
                if (a % 2 == 1 && a < N)
                {
                    Console.WriteLine("Нечетные числа");
                }
                a++;
            }
            Console.ReadKey();
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
            int i = 0;
            while (i < 6)
            {
                Console.WriteLine("Hello world!");
                i++;
            }
            Console.ReadKey();
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            Console.WriteLine("Введите число X ,которое будет возводиться в степень: ");
            var x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число Y, котторая будет являться степенью числа Х: ");
            var y = Convert.ToInt32(Console.ReadLine());

            var s = Math.Pow(x, y);

            Console.WriteLine(s);

            Console.ReadLine();
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            Console.WriteLine("");

            int result = 0;

            while (result != 4)
            {
                Console.WriteLine("Решите уравнение 2+2!\n");
                Console.WriteLine("Введите результат: ");
                result = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Решение верное");

            Console.ReadKey();
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            Console.WriteLine("Алгоритм игры с костями на 25 клеток");
            int step;
            int dice = 0;


            while (dice < 25)
            {
                Console.WriteLine("Введите число от 1 до 6: ");
                step = Convert.ToInt32(Console.ReadLine());
                dice += step;

            }

            Console.WriteLine("Вы дошли до финиша");

            Console.ReadKey();

        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            Console.WriteLine("Алгоритм игры с костями на 25 клеток");
            int step1;
            int dice1 = 0;

            int step2;
            int dice2 = 0;

            while (dice1 < 25 & dice2 < 25)
            {
                Console.WriteLine("Первый игрок бросайте кости: ");
                step1 = Convert.ToInt32(Console.ReadLine());
                dice1 += step1;
                Console.WriteLine("Результат {0}", dice1);

                Console.WriteLine("Второй игрок бросайте кости: ");
                step2 = Convert.ToInt32(Console.ReadLine());
                dice2 += step2;
                Console.WriteLine("Результат {0}", dice2);
            }

            Console.WriteLine("Вы дошли до финиша");
            if (dice1 > dice2)
            {
                Console.WriteLine("Выиграл первый игрок");
            }
            else
            {
                Console.WriteLine("Выиграл второй игрок");
            }

            Console.ReadKey();
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
        {
            Console.WriteLine("Введите число");
            var x = Convert.ToInt32(Console.ReadLine());
            int s;

            do
            {
                Console.WriteLine("Неверное значение. Повторите попытку");
                s = Convert.ToInt32(Console.ReadLine());
            }
            while (s != 100);

            Console.ReadKey();
        }


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            Console.WriteLine("Калькулятор If-Else");

            double x = 0;
            double y = 0;

            Console.WriteLine("Введите число 1: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            var buttom = Convert.ToChar(Console.ReadLine());
            if (buttom == '+')
            {
                Console.WriteLine("Сумма чисел равна {0}", (x + y));
            }
            else if (buttom == '-')
            {
                Console.WriteLine("Разница чисел равна {0}", (x - y));
            }
            else if (buttom == '*')
            {
                Console.WriteLine("Произведение чисел равно {0}", (x * y));
            }
            else if (buttom == '/')
            {
                Console.WriteLine("Частное чисел равно {0}", (x / y));
            }
            else
            {
                Console.WriteLine("Введите другую операцию");
            }

            Console.ReadKey();

        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            Console.WriteLine("Калькулятор swich");

            double x = 0;
            double y = 0;

            Console.WriteLine("Введите число 1: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            var buttom = Convert.ToChar(Console.ReadLine());
            switch (buttom)
            {
                case '+':
                    {
                        Console.WriteLine(x + y);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(x - y);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(x * y);
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(x / y);
                        break;
                    }
            }

            Console.ReadKey();

        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            Console.WriteLine("Введите слово: ");
            var word = Convert.ToString(Console.ReadLine());

            char[] array = word.ToCharArray();
            int last = array.Length - 1;
            for (int i = last; i > 0; i--)
            {
                Console.Write(array[i]);
            }


            Console.ReadKey();
        }
    }
}
