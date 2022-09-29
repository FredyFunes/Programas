using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            Console.Write("La conversion es de: " + hora * 60);
            Console.Write("La conversion de segundos es de: \n " + hora * seg);
            Console.Read();
        }
    }
}
