// 04 - Desenvolva uma aplicação em linguagem C# que solicite ao usuário um número e retorne a tabuada desse número de 0 a 10.

using System;

namespace MeuPrograma


{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int saveNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++) {
                Console.WriteLine(saveNum + " x " + i + " = " + saveNum*i);
            }
        }
    }
}