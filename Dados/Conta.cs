using System;

namespace Dados
{
    public class Conta
    {
        public string banco{get;set;}
        public string agencia{get;set;}
        public string conta{get;set;}
        public double saldo{get; protected set;}

        public virtual double Sacar(double _valor)
        {
            if(_valor<=this.saldo){
                return this.saldo -= _valor;
            }
            
            return 0;
        }

        public void Depositar(double _valor){
            this.saldo += _valor;
            Console.WriteLine("Novo Saldo: "+this.saldo);
        }

        public double MeuSaldo(){
            return this.saldo;
        } 

    }
}
