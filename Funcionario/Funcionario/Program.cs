
using Funcionario;

Func funcionaio = new Func();
System.Console.WriteLine("Digite dados do funcionário");

System.Console.Write("Nome: ");
funcionaio.Nome = Console.ReadLine();

System.Console.Write("Bruto: ");
funcionaio.Bruto = double.Parse(Console.ReadLine());

System.Console.Write("Imposto: ");
funcionaio.Imposto = double.Parse(Console.ReadLine());

System.Console.WriteLine(" ");

System.Console.WriteLine(funcionaio);
System.Console.WriteLine(" ");

System.Console.Write("Digite a porcentagem do aumento de salario: ");
funcionaio.AumentoSalario(double.Parse(Console.ReadLine()));

System.Console.WriteLine(" ");
System.Console.WriteLine(funcionaio);