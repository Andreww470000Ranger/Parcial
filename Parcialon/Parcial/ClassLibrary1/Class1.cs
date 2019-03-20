using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        int Num1, Num2;

        //Ejercicio 1
        public void Multiplicacion() 
        {
            Console.Clear();
            Console.WriteLine("Ingrese el primer numero");
            Num1 = int.Parse(Console.ReadLine());

            if (Num1 == 0)
            {
                Console.WriteLine("Ingrese un valor distinto a 0");
            }
            else
            {
                Console.WriteLine("Ingrese el segundo numero");
                Num2 = int.Parse(Console.ReadLine());

                int Producto = Num1 * Num2;

                Console.WriteLine("El producto es: "+Producto);

            }

        }

        //Ejercicio 2
        public void Division()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el numero que quiere dividir");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero divisor");
            Num2 = int.Parse(Console.ReadLine());

            if (Num2 == 0)
            {
                Console.WriteLine("ERROR: No se puede dividir entre 0");
            }
            else
            {
                int Resultado = Num1 / Num2;
                Console.WriteLine("El Resultado de la division es: " + Resultado);
            }
        }

        //Ejercicio 3

        public void Nombre()
        {
            Console.Clear();
            int i = 1;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("INGRESE UN NOMBRE");
                String Nombre = Console.ReadLine();
                Console.WriteLine("El nombre ingresado es: "+Nombre);
            }
        }

        //Ejercicio 4

        public void Edades()
        {
            Console.Clear();
            int i = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("INGRESE UNA EDAD");
                int Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("La edad ingresado es: " + Edad);
                i++;
            }while(i <= 5);
        }

    }
}
