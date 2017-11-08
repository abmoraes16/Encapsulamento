using System;
using Dados;
using util;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Validacao validacao = new Validacao();

            conta.Depositar(250);

            Console.WriteLine(conta.MeuSaldo());

            Console.Write("Digite o CPF: ");

            string documento = Console.ReadLine();

            if(validacao.ValidarCPF(documento)){
                Console.WriteLine("CPF válido!");
            } 

            /* ContaPessoaFisica contaPF = new ContaPessoaFisica();

            Console.WriteLine(contaPF.Sacar(1.20));

            ContaPessoaJuridica contaPJ = new ContaPessoaJuridica();

            Console.WriteLine(contaPJ.Sacar(2.0)); */

        }
    }
}
