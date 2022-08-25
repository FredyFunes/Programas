using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act1
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero;
            double hora = 60;
            double seg = 3600;
            int horatotal;
            int entero3;
            int entero4;
            int area;
            int entero5;
            int entero6;
            int entero7;
            int perimetro;
            Console.Write("************************Ejercicio1************************************ \n");
            Console.Write("Ingrese hora que desea convertir: ");
            entero = int.Parse(Console.ReadLine());
            Console.Write("La conversion es de: " + hora*60);
            Console.Write("La conversion de segundos es de: \n " + hora*seg );
           

            Console.Write("************************Ejercicio2************************************ \n");
            Console.Write("Ingrese la altura: ");
            entero3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la base: ");
            entero4 = int.Parse(Console.ReadLine());
            Console.Write("La conversion es de: \n " + (entero3 * entero4)/2 );

            Console.Write("Ingrese A: ");
            entero5 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese B: ");
            entero6 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese C: ");
            entero7 = int.Parse(Console.ReadLine());
            Console.Write("La conversion es de: " + (entero5 + entero6 + entero7));
            Console.Read();

            Console.Write("************************Ejercicio3************************************ \n");

        }
    }
}
      
