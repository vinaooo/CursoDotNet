using Estoque;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite os dados do produto:");
        Console.Write("Nome:");
        string nomeProduto = Console.ReadLine();
        Console.Write("Preco:");
        double preco = double.Parse(Console.ReadLine());
        Console.Write("Quantidade:");
        int quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine("");


        ControleEstoque controle = new ControleEstoque(nomeProduto, preco, quantidade);

        System.Console.WriteLine("Dados do produto:" + controle);
        Console.WriteLine("");
        System.Console.Write("Digite a quantidade de produtos que deseja adicionar:");
        controle.AdicionarProdutos(int.Parse(Console.ReadLine()));
        Console.WriteLine("");
        System.Console.WriteLine("Dados do produto:" + controle);
        Console.WriteLine("");
        System.Console.Write("Digite a quantidade de produtos que deseja remover:");
        controle.RemoverProdutos(int.Parse(Console.ReadLine()));
        Console.WriteLine("");
        System.Console.WriteLine("Dados do produto:" + controle);
    }
}