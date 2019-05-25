using System;
using System.Globalization;
using Classe_Metodos_Abstratos.Entities;
using Classe_Metodos_Abstratos.Entities.Enum;
using System.Collections.Generic;

namespace Classe_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> colors = new List<Shape>();
            Console.Write("Enter the number of shapes:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n -------------- \n");

                Console.Write("Rectangle or Circle (R/C)? ");
                char opc = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Color (Black/Blue/Red: ");
                string color = Console.ReadLine();

                if (opc == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    colors.Add(new Rectangle(width, height, Enum.Parse<Color>(color)));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    colors.Add(new Circle(radius, Enum.Parse<Color>(color)));
                }
            }

            Console.WriteLine("\n SHAPE AREAS \n");

            foreach (var s in colors)
            {
                Console.WriteLine(s.Area().ToString("F3", CultureInfo.InvariantCulture));
            }
        }
    }
}
