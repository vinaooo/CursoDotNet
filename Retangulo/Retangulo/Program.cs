using System;
using Retangulo;

namespace Program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retang retang = new Retang();
            Console.WriteLine("Digite os lados do retangulo:");
            string[] lados = Console.ReadLine().Split(' ');
            retang.LadoA = double.Parse(lados[0]);
            retang.LadoB = double.Parse(lados[1]);
            System.Console.WriteLine("");
            System.Console.WriteLine("Área: " + retang.Area());
            System.Console.WriteLine("Perímetro: " + retang.Perimetro());
            System.Console.WriteLine("Diagonal: " + retang.Diagonal());

        }
    }
}