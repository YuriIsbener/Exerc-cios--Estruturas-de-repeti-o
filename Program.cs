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

            //Console.Write("Usuário: ");
            //string usuario = Console.ReadLine();
            //Console.Write("Senha: ");
            //string senha = Console.ReadLine();

            //while(senha == usuario)
            //{
                //Console.WriteLine("Senha ou usuário invalidos, por favor tente novamente");
                //Console.Write("Usuário: ");
                //usuario = Console.ReadLine();
                //Console.Write("Senha: ");
                //senha = Console.ReadLine();
            //}

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            while(String.IsNullOrEmpty(nome))
            {
             Console.Write("Nome inválido, tente novamente");
             nome = Console.ReadLine();   
            }
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            while(idade < 0 || idade > 150)
            {
                Console.Write("Idade inválida, tente novamente");
                idade = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite seu salário: ");
            float salario = float.Parse(Console.ReadLine());
            while(salario < 0)
            {
                Console.Write("Salário inválida, tente novamente");
                salario = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Qual seu estado civil?");
            Console.WriteLine("'s'(solteiro(a), 'c'(casado(a), 'v'(viuvo(a), 'd'(divorciado(a)");
            char estado = char.Parse(Console.ReadLine());
            

        }
    }
}
