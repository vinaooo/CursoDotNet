namespace Banco2;

class Conta
{

    private string _nomeTitular;
    public double Saldo { get; private set; }
    public int NumeroConta { get; private set; }

    public Conta()
    {

    }
    public Conta(string nomeTitular, double valor, int conta)
    {
        _nomeTitular = nomeTitular;
        Saldo = valor;
        NumeroConta = conta;
    }
    public string Nome
    {
        get { return _nomeTitular; }
        set
        {
            if (value != null && value.Length > 2)
            {
                _nomeTitular = value;
            }
        }
    }
    public void Depositar(double valor)
    {
        Saldo += valor;
    }
    public void Sacar(double valor)
    {
        Saldo = Saldo - valor - 5;
    }
    override public string ToString()
    {
        return "Dados da conta atualizados:\n"
        + "Conta: " + NumeroConta
        + ", Titular: " + Nome
        + ", Saldo: " + Saldo;
    }
}
