using System;

namespace FindAreas
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название геометрической фигуры, площадь которой вам необходимо найти (регистр не имеет значения)");
            string n = Console.ReadLine();
            string name = n.ToLower(); //Перевод переменной в нижний регистр

            switch (name)
            {
                case "треугольник":
                    Console.WriteLine("После нажатия Enter, введите 3 стороны треугольника : ");
                    Console.WriteLine("Введите первую сторону : ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону : ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третью сторону : ");
                    double c = double.Parse(Console.ReadLine());// Ввод трех сторон треугольника
                    if (a + b > c & a + c > b & b + c > a) // Проверка существования треугольника
                    {
                        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) | Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2) | Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                        {//Проверка того, является ли треугольник прямоугольным
                            Console.WriteLine("Ваш треугольник прямоугольный");
                        }
                        else
                        {
                            Console.WriteLine("Ваш треугольник не прямоугольный");
                        }
                        double p = (a + b + c) / 2; // Нахождение полупериметра в отдельной переменной
                        double S_triangle = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //Нахождение площади по трем сторонам
                        Console.WriteLine($"Площадь вашего треугольнка равна : {S_triangle}");
                    }

                    else
                    {
                        Console.WriteLine("Такого треуголинка не существует");
                        break;
                    }

                    break;
                case "круг":
                    Console.WriteLine("Введите радиус круга");
                    double r = double.Parse(Console.ReadLine());
                    double S_circle = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine($"Площадь вашего круга равна = {S_circle}");
                    break;
            }
        }
    }
}
