using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            float p, i;
            string l;

            Console.WriteLine("¿Cuantos articulos desea llevar?");
            l = Console.ReadLine();
            c = int.Parse(l);

            Console.WriteLine("Ingrese el precio unitario del producto");
            l = Console.ReadLine();
            p = float.Parse(l);

            i = c*p;

            Console.WriteLine("El importe asciende a: " + i);
            Console.ReadKey();
        }
    }
}
