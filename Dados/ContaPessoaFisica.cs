namespace Dados
{
    public class ContaPessoaFisica : Conta
    {
        //Agregação
        Pessoa pessoa {get;set;}

/// <summary>
/// Sacar adaptado para Pessoa Fisica :: Sobrescrito da classe pai
/// </summary>
/// <param name="valor">saque</param>
/// <returns>Saldo</returns>
    public override double Sacar(double valor){
        base.Sacar(valor);
        //this.saldo+=valor+1;

        return this.saldo;
    }

    }
}