using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_parte_1
{
    public abstract class Geometricos
    {
        //Abstraccion obliga a la herencia, a que se realicen metodos o atributos en las clases hijas
        //NO se puede instanciar la clase abstracta
        public abstract string Nombre { get; set; }
        public abstract void Saludar();

        //calcular area de cuadrado,triangulo,rectangulo
        public abstract double CalcularArea(double a,double b);
        public abstract double Perimetro(double a, double b);
        public abstract double Ladoa { get; set; }
        public abstract double Ladob { get; set; }
    }
}
