using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            
            Triangulo t = new Triangulo();
            Cuadrado c = new Cuadrado();
            Rectangulo r = new Rectangulo();
            t.Saludar();

            

            Console.WriteLine("Ingrese la opcion que desea ver: ");
            Console.WriteLine("1.Cuadrado" + "\n2.Triangulo" + "\n3.Rectangulo");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    c.Saludar();
                    c.Perimetro(5,5);
                    c.CalcularArea(5,5);
                    break;

                case 2:
                    t.Saludar();
                    t.CalcularArea(4,3);
                    break;
                case 3:
                    r.Saludar();
                    r.Perimetro(4,6);
                    r.CalcularArea(4, 6);

                    break;
            }






            Console.ReadKey();
        }
    }
}
