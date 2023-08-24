using ConversaoDolar;
using System.Globalization;

System.Console.Write("Cotação: ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.Write("Quantidade: ");
double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double total = CalcDolar.total(cotacao, quantidade);
System.Console.WriteLine($"Total: {(total).ToString("F2", CultureInfo.InvariantCulture)}");