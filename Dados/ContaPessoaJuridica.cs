namespace Dados{
    public class ContaPessoaJuridica : Conta
    {
        //agregação
        Empresa empresa {get;set;}

        public override double Sacar(double _valor){
            this.saldo += _valor + 2;

            return this.saldo;
        }
    }
}