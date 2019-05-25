using Classe_Metodos_Abstratos.Entities.Enum;
using Classe_Metodos_Abstratos.Entities;
using System;

namespace Classe_Metodos_Abstratos
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }
    }
}
