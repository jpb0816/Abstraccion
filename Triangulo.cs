using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_parte_1
{
    public class Triangulo : Geometricos
    {
        public override string Nombre { get; set; }
        public override double Ladoa { get ; set ; }
        public override double Ladob { get ; set ; }

        public override double CalcularArea(double a, double b)
        {
            double area = (a * b) / 2;
            Console.WriteLine("El area es: "+area);
            return area;
        }

        public override double Perimetro(double a, double b)
        {
            return 0;
        }

        public override void Saludar()
        {

            Console.WriteLine("Este es un triangulo");
        }
    }
}
