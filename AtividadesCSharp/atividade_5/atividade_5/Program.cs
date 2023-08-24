// 05 - Construa uma aplicação em C# em que o usuário insere um númnero e a aplicação retorna se o número é par ou ímpar.

using System;

namespace MeuPrograma


{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            int saveNum = Convert.ToInt32(Console.ReadLine());

            if(saveNum % 2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é impar!");
            }
        }
    }
}