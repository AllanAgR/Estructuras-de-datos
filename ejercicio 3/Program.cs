using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string l;

            Console.WriteLine("ingrese un numero positivo de hasta 3 digitos");
            l = Console.ReadLine();
            n = int.Parse(l);

            if(n < 10){

                Console.WriteLine("El numero tiene un digito");
            }
            else{

                if(n < 100){
                    Console.WriteLine("El numero tiene dos digitos");
                }
                else{
                    if(n < 1000){
                        Console.WriteLine("El numero tiene tres digitos");

                    }
                    else{
                        Console.WriteLine("Error");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
