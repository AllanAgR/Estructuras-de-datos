using System;

namespace Nueva_carpeta
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            int p;
            string linea;

            Console.WriteLine("ingrese la medida del lado del cuadrado");
            linea = Console.ReadLine();
            l = int.Parse(linea);

            p = l*4;

            Console.WriteLine("El perimetro del cuadrado es: " + p);
            Console.ReadKey();

        }
    }
}
