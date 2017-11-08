using System;

namespace Dados{
    public class ContaPessoaJuridica : Conta
    {
        //agregação
        Empresa empresa {get;set;}

        public override double Sacar(double _valor){
            this.saldo += _valor + 2;

            return this.saldo;
        }

        public bool CadastrarPessoa(string _banco, string _agencia, string _conta, double _saldo, string _razaoSocial, DateTime _dataAbertura, string _CNPJ)
        {
            this.banco = _banco;
            this.agencia = _agencia;
            this.conta = _conta;
            this.saldo = _saldo;

            empresa = new Empresa();

            empresa.razaoSocial = _razaoSocial;
            empresa.dataAbertura = _dataAbertura;
            empresa.CNPJ = _CNPJ;

            MostraDados();
            
            return true;
        }

        public void MostraDados(){
            Console.WriteLine("\nRelatório de dados da conta cadastrada:\n");
            Console.WriteLine("CNPJ: "+empresa.CNPJ);
            Console.WriteLine("Razão Social: "+empresa.razaoSocial);
            Console.WriteLine("Data abertura: "+empresa.dataAbertura+"\n");

            Console.Write("Banco: "+this.banco);
            Console.Write("\tAgencia: "+this.agencia);
            Console.Write("\tConta: "+this.conta);

            Console.WriteLine("\n\nSaldo: "+this.saldo+"\n");
        }
    }
}