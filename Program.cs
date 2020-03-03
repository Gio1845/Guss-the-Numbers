using System;

namespace Guss_the_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //numero random a buscar
            int x;
            //numero que esciribio el usuario
            string num;
            int num2;
            Console.WriteLine("introduce un numero del 1 al 100 para definir el rango de numero que vas adivinar");
            num = Console.ReadLine();
            num2 = Convert.ToInt32(num);

             
            //numero de intentos
            int count = 0;

            Random r = new Random ();
            x = Convert.ToInt32(Math.Floor(r.NextDouble()*num2));
            
            
        }
    }
}
