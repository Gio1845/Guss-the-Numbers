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

            Random r = new Random();
            x = Convert.ToInt32(Math.Floor(r.NextDouble() * num2));
            Console.WriteLine("Adivina el numero entre el 1 y el numero que introdugiste anteriormente");
            num = Console.ReadLine();
            num2 = Convert.ToInt32(num);

            int i = 0;

            while (i == 0)
            {

                Console.WriteLine("Adivina el numero entre el 0 y el numero que introdugiste anteriormente");
                num = Console.ReadLine();
                num2 = Convert.ToInt32(num);

                count++;
                if (num2 > x)
                {
                    Console.WriteLine("el numero por adivinar es menor a ese");
                }
                else if (num2 < x)
                {
                    Console.WriteLine("el numero a adivinar es mayor a ese");
                }
                else
                {
                    Console.WriteLine("Adivinaste, felicidades");
                    Console.WriteLine($"tu numero de intentos fue {count}");
                    i = 1;
                }

            }

        }
    }
}
