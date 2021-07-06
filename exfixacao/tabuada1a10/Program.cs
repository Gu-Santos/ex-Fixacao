using System;

namespace tabuada1a10
{
    class Program
    {
        static void Main(string[] args)
        {

           for (int numeros_tabuada = 1; numeros_tabuada < 11; numeros_tabuada++)
           {
               for (int numeros_multiplicados = 1; numeros_multiplicados < 11; numeros_multiplicados++)
               {
                Console.WriteLine(numeros_tabuada*numeros_multiplicados);
               }
           }
        }
    }
}
