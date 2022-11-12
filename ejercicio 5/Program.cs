using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            string l;

            Console.WriteLine("Ingrese la coordenada x");
            l = Console.ReadLine();
            x = int.Parse(l);

            Console.WriteLine("Ingrese la coordenada y");
            l = Console.ReadLine();
            y = int.Parse(l);

            if (x>0 && y >0)
            {
                Console.WriteLine("Se encuentra en el primer cuadrante");
            }
            else{

                if (x<0 && y>0)
                {
                    Console.WriteLine("Se encuentra en el segundo cuadrante");
                }
                else{

                    if (x<0 && y<0)
                    {
                        Console.WriteLine("Se encuentra en el tercer cuadrante");
                    }
                    else{
                        Console.WriteLine("Se encuentra en el cuarto cuadrante");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
