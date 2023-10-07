using System;

namespace FindAreas
{
    public static class FindAreas
    {
        public static double S_triangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a) // Проверка существования треугольника
            {
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                {//Проверка того, является ли треугольник прямоугольным
                    Console.WriteLine("Ваш треугольник прямоугольный");
                }
                else
                {
                    Console.WriteLine("Ваш треугольник не прямоугольный");
                }
                double p = (a + b + c) / 2; // Нахождение полупериметра в отдельной переменной
                double S_triangle = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //Нахождение площади по трем сторонам
                return S_triangle;
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
                return 0; // Возвращаем 0 в случае неверных сторон
            }
        }

        public static double S_circle(double r)
        {
            double S_circle = Math.PI * Math.Pow(r, 2);
            return S_circle;
        }
    }
}

