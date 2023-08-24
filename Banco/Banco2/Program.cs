using Banco2;

System.Console.Write("Digite o numero da Conta: ");
int numConta = int.Parse(Console.ReadLine());

System.Console.Write("Digite o nome do Titular: ");
string _nomeTitular = Console.ReadLine();

System.Console.Write("Haverá depósito inicial? (s/n): ");
string depositoInicial = Console.ReadLine();

double deposito = 0;

if (depositoInicial == "s")
{
    System.Console.Write("\nDigite o valor do deposito inicial: ");
    deposito = double.Parse(Console.ReadLine());
}
else
{
    deposito = 0;
}
Conta conta = new Conta(_nomeTitular, deposito, numConta);
System.Console.WriteLine(conta);

System.Console.Write("\nDigite um valor de depósito: ");
conta.Depositar(double.Parse(Console.ReadLine()));
System.Console.WriteLine(conta);

System.Console.Write("\nDigite um valor de saque: ");
conta.Sacar(double.Parse(Console.ReadLine()));
System.Console.WriteLine(conta);