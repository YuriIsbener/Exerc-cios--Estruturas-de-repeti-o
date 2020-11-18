using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor ");
                int numero = int.Parse(Console.ReadLine());

            while(numero > 10 || numero <= 0)
            {   
                Console.WriteLine("Valor invalido, tente novamente ");
                int.Parse(Console.ReadLine());
            }

        }
    }
}
