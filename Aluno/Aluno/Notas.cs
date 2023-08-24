using System.Runtime.InteropServices;

namespace Aluno;

public class Notas
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double notafinal()
    {
        return Nota1 + Nota2 + Nota3;
    }
    override public string ToString()
    {
        if (notafinal() >= 60)
        {
            return "Nota final: "
            + notafinal()
            + "\nAPROVADO";
        }
        else
        {
            return "Nota final: "
            + notafinal()
            + "\nREPROVADO"
            + "\nFaltaram "
            + (60 - notafinal())
            + " pontos";


        }
    }

}
