using System;
using Dados;
using util;

namespace Terminal
{
    class Program
    {
        static string opcao;
        static Validacao validacao = new Validacao();
        static ContaPessoaJuridica contaPJ = new ContaPessoaJuridica();
        static void Main(string[] args)
        {
            //Menu principal
            do
            {
                Console.WriteLine("\nEscolha uma das opções abaixo\n1 - Cadastrar Conta\n2 - Sacar\n3 - Depositar\n\n0 - Sair\n");

                do
                {
                    opcao = Console.ReadLine();
                } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "0");

                switch (opcao)
                {
                    case "0": Environment.Exit(0); break;
                    case "1": CadastrarConta(); break;
                    case "2": //; break;
                    case "3": //; break;
                    case "4":  break;
                }

            } while (opcao != "0");




        }

        public static void CadastrarConta(){
            do{
            Console.WriteLine("Digite 1 para Pessoa Jurídica e 2 para Pessoa Física");
            opcao = Console.ReadLine();
            }while(opcao!="1" && opcao!="2");

            bool valido;    
        
            switch(opcao){
                case "1":
                    string cnpj;
                    do{
                        Console.WriteLine("Digite o CNPJ: ");
                        cnpj = Console.ReadLine();
                        valido = validacao.ValidarCNPJ(cnpj);
                    }while(!valido);

                    Console.Write("Digite a Razão Social: ");
                    string razaoSocial = Console.ReadLine();

                    Console.Write("Digite o banco: ");
                    string banco = Console.ReadLine();

                    Console.Write("Digite a agência: ");
                    string agencia = Console.ReadLine();

                    Console.Write("Digite o conta: ");
                    string conta = Console.ReadLine();

                    Console.Write("Digite o saldo: ");
                    double saldo = double.Parse(Console.ReadLine());

                    bool cadastrada = contaPJ.CadastrarPessoa(banco,agencia,conta,saldo,razaoSocial,DateTime.Now,cnpj);

                    if(cadastrada){
                    Console.WriteLine("Conta cadastrada com sucesso!\n");
                    }
                    else{
                        Console.WriteLine("Conta cadastrada com sucesso!\n");
                    }

                    break;
                case "2":
                    do{
                        Console.WriteLine("Digite o CPF: ");
                        string cpf = Console.ReadLine();
                        valido = validacao.ValidarCPF(cpf);
                    }while(!valido);
                    break;
            }


        }
    }
}
