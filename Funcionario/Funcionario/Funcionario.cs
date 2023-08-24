using System.Globalization;

namespace Funcionario;

public class Func
{
    public string Nome;
    public double Bruto;
    public double Imposto;
    public override string ToString()
    {
        return "Funcionario: "
        + Nome
        + ", R$ "
        + (Bruto - Imposto).ToString("F2", CultureInfo.InvariantCulture);

    }

    public void AumentoSalario(double porcentagem)
    {
        Bruto += Bruto * porcentagem / 100;
    }

}
