using Aluno;

Notas aluno = new Notas();

System.Console.WriteLine("Digite os dados do aluno:");
System.Console.Write("Nome:");
aluno.Nome = System.Console.ReadLine();
System.Console.Write("Nota 1:");
aluno.Nota1 = double.Parse(System.Console.ReadLine());
System.Console.Write("Nota 2:");
aluno.Nota2 = double.Parse(System.Console.ReadLine());
System.Console.Write("Nota 3:");
aluno.Nota3 = double.Parse(System.Console.ReadLine());

System.Console.WriteLine(aluno);