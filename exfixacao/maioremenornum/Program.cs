using System;

namespace maioremenornum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int maior_numero;
            int menor_numero;


            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Escreva um número: ");
                numeros[contador] = int.Parse(Console.ReadLine());
            }

            maior_numero = numeros[0];
            menor_numero = numeros[0];

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] < menor_numero)
                {
                    menor_numero = numeros[i];
                }
                
                if (numeros[i] > maior_numero)
                {
                    maior_numero = numeros[i];
                }
                    
            }


            Console.WriteLine("O maior valor digitado foi: " + maior_numero);

            Console.WriteLine("O menor valor digitado foi: " + menor_numero);

        }
    }
}
