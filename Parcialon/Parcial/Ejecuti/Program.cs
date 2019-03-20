using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejecuti
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Console.WriteLine("¿Que ejercicio desea examinar?");
            int Opcion = int.Parse(Console.ReadLine());

            switch (Opcion) 
            {
                case 1:
                    obj1.Multiplicacion();
                    break;

                case 2:
                    obj1.Division();
                    break;

                case 3:
                    obj1.Nombre();
                    break;

                case 4:
                    obj1.Edades();
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta!!!!");
                    break;

            }
            
        }
    }
}
