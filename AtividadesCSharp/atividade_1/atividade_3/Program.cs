// 01 -  Escreva um programa em C# que peça ao usuário que digite um número inteiro e então imprima o número digitado pelo usuário.

using System;

namespace atividade_1


{
    class exercicio_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O número: " + numInt);

        }
    }
}