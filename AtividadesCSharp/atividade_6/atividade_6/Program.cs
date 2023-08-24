// 06 Escreva um programa em C# que compute a soma de dois valores numéricos inseridos pelo usuário. Se os valores forem iguais, retornar o triplo da soma entre ambos.

using System;

namespace atividade_6

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2) { 
                int resul = (num1 + num2)*3;
                Console.WriteLine(resul);
            }
            Console.WriteLine("Os números não são iguais!");
        }
    }
}