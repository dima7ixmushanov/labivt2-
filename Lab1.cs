﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabIVT2
{
    internal class Lab1
    {
        public void task1()
        {
            int d = 0;
            double x = 27.3198;
            string tmp = Math.Round(x, 1).ToString();
            Console.WriteLine(tmp);
            d = int.Parse(tmp[tmp.Length - 1].ToString());
            Console.WriteLine("Resurt=" + d);
        }

        public void task2()
        {
            DateTime time = DateTime.Now;
            int hour = time.Hour;
            int minute = time.Minute;
            int second = time.Second;
            int x = 86400;
            Console.WriteLine("Прошло с начала суток\t" + (hour * 3600 + minute * 60 + second));
            Console.WriteLine("Осталось до конца суток\t" + (x - hour * 3600 + minute * 60 + second));
        }

        public void task3()
        {
            Console.Write("Введите количество часов (0-11): ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Введите количество минут (0-59): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество секунд (0-59): ");
            int s = int.Parse(Console.ReadLine());
            double angle = h * 30 + m * 0.5 + s * (0.5 / 60);
            Console.WriteLine("Угол между положением часовой стрелки в начале суток и в указанное время: " + angle + "градусов");
        }

        public void task4()
        {
            int a = 14;
            int b = 40;
            Console.WriteLine("До обмена: a = " + a + ", b = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("После обмена: a = " + a + ", b = " + b);
        }

        public void task5()
        {
            Console.Write("Введите длину первого катета: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину второго катета: ");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            double area = 0.5 * a * b;
            double perimeter = a + b + c;
            Console.WriteLine("Площадь треугольника: " + area);
            Console.WriteLine("Периметр треугольника: " + perimeter);
        }

        public void task6()
        {
            Console.Write("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Ошибка: введено не четырехзначное число.");
                return;
            }
            int x1 = number / 1000;
            int x2 = (number / 100) % 10;
            int x3 = (number / 10) % 10;
            int x4 = number % 10;
            int product = x1 * x2 * x3 * x4;
            Console.WriteLine("Произведение цифр числа: " + product);
        }

        public void task7()
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: введено не трехзначное число.");
                return;
            }
            int x1 = number / 100;
            int x2 = (number / 10) % 10;
            int x3 = number % 10;
            int result = x3 * 100 + x2 * 10 + x1;
            Console.WriteLine("Число в обратном порядке: " + result);
        }

        public void task8()
        {
            Console.Write("Введите действительное число x: ");
            double x = double.Parse(Console.ReadLine());
            double x2 = x * x;       // x^2
            double x3 = x * x2;      // x^3
            double x4 = x * x3;      // x^4
            double result = 3 * x4 - 5 * x3 + 2 * x2 - x + 7;
            Console.WriteLine("Результат: " + result);
        }

        public void task9()
        {
            Console.WriteLine("Введите коэффициенты для первого уравнения (a1, b1, c1, d1): ");
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine());
            double d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициенты для второго уравнения (a2, b2, c2, d2): ");
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double c2 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициенты для третьего уравнения (a3, b3, c3, d3): ");
            double a3 = double.Parse(Console.ReadLine());
            double b3 = double.Parse(Console.ReadLine());
            double c3 = double.Parse(Console.ReadLine());
            double d3 = double.Parse(Console.ReadLine());
            double det = a1 * (b2 * c3 - b3 * c2) - b1 * (a2 * c3 - a3 * c2) + c1 * (a2 * b3 - a3 * b2);
            if (det == 0)
            {
                Console.WriteLine("Система не имеет решений (определитель равен 0).");
                return;
            }
            double Dx = d1 * (b2 * c3 - b3 * c2) - b1 * (d2 * c3 - d3 * c2) + c1 * (d2 * b3 - d3 * b2);
            double Dy = a1 * (d2 * c3 - d3 * c2) - d1 * (a2 * c3 - a3 * c2) + c1 * (a2 * d3 - a3 * d2);
            double Dz = a1 * (b2 * d3 - b3 * d2) - b1 * (a2 * d3 - a3 * d2) + d1 * (a2 * b3 - a3 * b2);
            double x = Dx / det;
            double y = Dy / det;
            double z = Dz / det;
            Console.WriteLine($"Решение системы: x = {x}, y = {y}, z = {z}");
        }

        private void PrintRow(string[] row)
        {
            foreach (var cell in row)
            {
                Console.Write($"| {cell,-20}");
            }
            Console.WriteLine("|");
        }

        private void PrintSeparator(int columns)
        {
            for (int i = 0; i < columns; i++)
            {
                Console.Write("+---------------------");
            }
            Console.WriteLine("+");
        }

        enum Regime
        {
            Ф = 0,
            УГ = 1,
        }

        struct Geography
        {
            public string state { get; set; }
            public string capital { get; set; }
            public int population { get; set; }
            public Regime regime { get; set; }
        }

        public void task10()
        {
            int rows = 3;
            int columns = 4;

            Geography[] geography = new Geography[rows];

            string[] state = new string[] { "Австралия", "Австрия", "Италия" };
            string[] capital = new string[] { "Канберра", "Вена", "Рим" };
            int[] population = new int[] { 23130391, 8420010, 61482020 };
            Regime[] regime = new Regime[] { Regime.Ф, Regime.Ф, Regime.УГ };

            for (int i = 0; i < rows; i++)
            {
                geography[i] = new Geography();
                geography[i].state = state[i];
                geography[i].capital = capital[i];
                geography[i].population = population[i];
                geography[i].regime = regime[i];
            }

            string[] headers = { "Государство", "Столица", "Население", "Строй" };
            PrintSeparator(columns);
            Console.WriteLine($"| {"География",-86}|");
            PrintSeparator(columns);

            string[,] table = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    switch (j)
                    {
                        case 0:
                            table[i, j] = geography[i].state; break;
                        case 1:
                            table[i, j] = geography[i].capital; break;
                        case 2:
                            table[i, j] = geography[i].population.ToString(); break;
                        case 3:
                            table[i, j] = geography[i].regime.ToString(); break;
                    }
                }
            }

            PrintRow(headers);
            PrintSeparator(columns);

            for (int i = 0; i < rows; i++)
            {
                string[] row = new string[columns];
                for (int j = 0; j < columns; j++)
                {
                    row[j] = table[i, j];
                }
                PrintRow(row);
                PrintSeparator(columns);
            }
            Console.WriteLine($"| {"Перечисляемый тип: Ф - федерация, УГ - унитарное государство",-86}|");
            PrintSeparator(columns);
        }

        public void task11()
        {
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("x=");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());

            double f = Math.Log(a + x * x) + Math.Pow(Math.Sin(x / b), 2);

            if ((a + x * x) <= 0)
            {
                Console.WriteLine("Ошибка. Под знаком натурального логарифма не может быть неположительное число");
            }

            if (b == 0)
            {
                Console.WriteLine("Ошибка. Делить на ноль нельзя");
            }

            else
            {
                Console.WriteLine($"Значение f = {f}");
            }

            double z = Math.Exp(-c * x) * (x + Math.Sqrt(x + a)) / (x - Math.Sqrt(Math.Abs(x - b)));

            if ((x + a) < 0)
            {
                Console.WriteLine("Ошибка. Под знаком корня не может быть отрицательное число");
            }

            if ((x - Math.Sqrt(Math.Abs(x - b))) == 0)
            {
                Console.WriteLine("Ошибка. Делить на ноль нельзя");
            }

            else
            {
                Console.WriteLine($"Значение z = {z}");
            }
        }
    }
}

       
