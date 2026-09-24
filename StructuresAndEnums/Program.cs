using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndEnums
{
        public class Program
        {
            public static void Main()
            {
                Console.WriteLine("Точки на плоскости");
                Console.WriteLine();

                int x;
                int y;

                while (true)
                {
                    try
                    {
                        Console.Write("Введите X: ");
                        x = int.Parse(Console.ReadLine());

                        Console.Write("Введите Y: ");
                        y = int.Parse(Console.ReadLine());

                        if (x == 0 || y == 0)
                        {
                            throw new ArgumentException(
                                "X и Y не должны быть равны нулю."
                            );
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: необходимо ввести целое число.");
                        Console.WriteLine();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        Console.WriteLine();
                    }
                }

                Point2D point1 = new Point2D
                {
                    X = x,
                    Y = y
                };

                Console.WriteLine();
                Console.WriteLine($"Точка: {point1}");
                Console.WriteLine();

                Point2D copy = point1;

                copy.X = -copy.X;
                copy.Y = -copy.Y;

                Console.WriteLine("Копирование структуры:");
                Console.WriteLine($"Оригинал: {point1}");
                Console.WriteLine($"Копия:    {copy}");
                Console.WriteLine();

                Console.WriteLine("Проверка Enum.TryParse:");

                Console.Write("Введите четверть для проверки Enum.TryParse: ");
                string input = Console.ReadLine();

                if (Enum.TryParse<Quadrant>(input, out Quadrant quadrant))
                {
                    Console.WriteLine(
                        $"\"{input}\" -> true, значение: {quadrant}"
                    );
                }
                else
                {
                    Console.WriteLine(
                        $"\"{input}\" -> false, без исключения"
                    );
                }
            }
        }
    }

