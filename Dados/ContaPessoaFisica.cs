namespace Dados
{
    public class ContaPessoaFisica : Conta
    {
        //Agregação
        Pessoa pessoa {get;set;}

/// <summary>
/// Sacar adaptado para Pessoa Fisica
/// </summary>
/// <param name="valor"></param>
/// <returns>Saldo</returns>
    public override double Sacar(double valor){
        //base.Sacar(valor);
        this.saldo+=valor+1;

        return this.saldo;
    }

    }
}