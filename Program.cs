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
            //numero de intentos
            int count = 0;

            Random r = new Random ();
            x = Convert.ToInt32(Math.Floor(r.NextDouble()*101));

            Console.WriteLine("Adivina el numero entre el 1 al 100");

            int i = 0;

            while(i == 0){
                Console.WriteLine("introduce un numero del 1 al 100 para definir el rango de numero que vas adivinar");
                num = Console.ReadLine();
                count ++;
                if(num > x){
                    Console.WriteLine("el numero por adivinar es menor a ese");
                }else if(num < x){
                    Console.WriteLine("el numero a adivinar es mayor a ese");
                }else{
                    Console.WriteLine("Adivinaste, felicidades");
                    Console.WriteLine("tu numero de intentos fue ", count);
                    i = 1;
                }

            }
            
            
        }
    }
}
