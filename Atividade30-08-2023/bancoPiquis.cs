using System;

class Program
{
    static string[] nomesDasContas = new string[100];
    static double[] saldosDasContas = new double[100];
    static int numeroDeContas = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Bem-vindo ao Banco Píquis!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Criar conta");
            Console.WriteLine("2. Ver contas criadas");
            Console.WriteLine("3. Sair");

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    CriarConta();
                    break;

                case 2:
                    VerContasCriadas();
                    break;

                case 3:
                    Console.WriteLine("Obrigado por usar o Banco Píquis. Adeus!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static void CriarConta()
    {
        Console.WriteLine("Digite o nome da conta:");
        string novaConta = Console.ReadLine().ToLower();

        if (EncontrarConta(novaConta) != -1)
        {
            Console.WriteLine("Essa conta já existe.");
            return;
        }

        Console.WriteLine("Digite o valor inicial da conta:");
        double valorInicial = Convert.ToDouble(Console.ReadLine());

        if (valorInicial < 0)
        {
            Console.WriteLine("O valor inicial da conta deve ser maior ou igual a zero.");
        }
        else
        {
            nomesDasContas[numeroDeContas] = novaConta;
            saldosDasContas[numeroDeContas] = valorInicial;
            numeroDeContas++;
            Console.WriteLine("Conta criada com sucesso com um saldo inicial de " + valorInicial.ToString("C2") + ".");
        }
    }

    static void VerContasCriadas()
    {
        Console.WriteLine("Contas criadas:");

        for (int i = 0; i < numeroDeContas; i++)
        {
            Console.WriteLine("- " + nomesDasContas[i]);
        }

        Console.WriteLine("Escolha uma conta para realizar operações:");
        string contaSelecionada = Console.ReadLine().ToLower();

        int indiceContaSelecionada = EncontrarConta(contaSelecionada);

        if (indiceContaSelecionada == -1)
        {
            Console.WriteLine("Conta não encontrada. Crie uma conta primeiro.");
        }
        else
        {
            RealizarOperacoes(indiceContaSelecionada);
        }
    }

    static void RealizarOperacoes(int indiceConta)
    {
        while (true)
        {
            Console.WriteLine("Conta de " + nomesDasContas[indiceConta] + ":");
            Console.WriteLine("1. Ver saldo");
            Console.WriteLine("2. Realizar transferência");
            Console.WriteLine("3. Realizar depósito");
            Console.WriteLine("4. Realizar saque");
            Console.WriteLine("5. Voltar ao menu anterior");

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    ExibirSaldo(indiceConta);
                    break;

                case 2:
                    RealizarTransferencia(indiceConta);
                    break;

                case 3:
                    RealizarDeposito(indiceConta);
                    break;

                case 4:
                    RealizarSaque(indiceConta);
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static void RealizarTransferencia(int indiceRemetente)
    {
        Console.WriteLine("Digite o nome do beneficiário:");
        string beneficiario = Console.ReadLine().ToLower();

        int indiceBeneficiario = EncontrarConta(beneficiario);

        if (indiceBeneficiario == -1)
        {
            Console.WriteLine("Conta do beneficiário não encontrada. Crie uma conta primeiro.");
            return;
        }

        Console.WriteLine("Digite o valor da transferência:");
        double valorTransferencia = Convert.ToDouble(Console.ReadLine());

        if (valorTransferencia <= 0)
        {
            Console.WriteLine("O valor da transferência deve ser maior que zero.");
        }
        else if (valorTransferencia > saldosDasContas[indiceRemetente])
        {
            Console.WriteLine("Saldo insuficiente para realizar a transferência.");
        }
        else
        {
            saldosDasContas[indiceRemetente] -= valorTransferencia;
            saldosDasContas[indiceBeneficiario] += valorTransferencia;
            Console.WriteLine("Transferência de " + valorTransferencia.ToString("C2") + " para " + beneficiario + " realizada com sucesso!");
        }
    }

    static void RealizarDeposito(int indiceConta)
    {
        Console.WriteLine("Digite o valor do depósito:");
        double valorDeposito = Convert.ToDouble(Console.ReadLine());

        if (valorDeposito <= 0)
        {
            Console.WriteLine("O valor do depósito deve ser maior que zero.");
        }
        else
        {
            saldosDasContas[indiceConta] += valorDeposito;
            Console.WriteLine("Depósito de " + valorDeposito.ToString("C2") + " realizado na conta de " + nomesDasContas[indiceConta] + ".");
        }
    }

    static void RealizarSaque(int indiceConta)
    {
        Console.WriteLine("Digite o valor do saque:");
        double valorSaque = Convert.ToDouble(Console.ReadLine());

        if (valorSaque <= 0)
        {
            Console.WriteLine("O valor do saque deve ser maior que zero.");
        }
        else if (valorSaque > saldosDasContas[indiceConta])
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
        else
        {
            saldosDasContas[indiceConta] -= valorSaque;
            Console.WriteLine("Saque de " + valorSaque.ToString("C2") + " realizado na conta de " + nomesDasContas[indiceConta] + ".");
        }
    }

    static void ExibirSaldo(int indiceConta)
    {
        Console.WriteLine("Saldo atual de " + nomesDasContas[indiceConta] + ": " + saldosDasContas[indiceConta].ToString("C2"));
    }

    static int EncontrarConta(string nome)
    {
        for (int i = 0; i < numeroDeContas; i++)
        {
            if (nomesDasContas[i] == nome)
            {
                return i;
            }
        }
        return -1;
    }
}
