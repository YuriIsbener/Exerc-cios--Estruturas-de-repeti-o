using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite um valor ");
                //int numero = int.Parse(Console.ReadLine());

            //while(numero > 10 || numero <= 0)
            //{   
                //Console.WriteLine("Valor invalido, tente novamente ");
                //int.Parse(Console.ReadLine());
            //}

            Console.Write("Usuário: ");
            string usuario = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            while(senha == usuario)
            {
                Console.WriteLine("Senha ou usuário invalidos, por favor tente novamente");
                Console.Write("Usuário: ");
                usuario = Console.ReadLine();
                Console.Write("Senha: ");
                senha = Console.ReadLine();
            }

        }
    }
}
