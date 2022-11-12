using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float s, am, st;
            int a;
            string l;

            Console.WriteLine("Ingrese el sueldo");
            l = Console.ReadLine();
            s = float.Parse(l);

            Console.WriteLine("Ingrese la antiegüedad");
            l = Console.ReadLine();
            a = int.Parse(l);

            if (s<500 && a>10)
            {
                am = s*0.20f;
                st = s+am;

                Console.WriteLine("Sueldo a pagar:" + st);
            }
            else
            {
                
                if (s<500)
                {
                    am = s*0.05f;
                    st = s+am;

                Console.WriteLine("Sueldo a pagar: " + st);
                }
                else
                {
                    Console.WriteLine("Sueldo a pagar: " + s);
                }
            }
            Console.ReadKey();
        }
    }
}
