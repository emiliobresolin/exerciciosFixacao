using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace oneOthree
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x;
            x = new Retangulo();
            Console.WriteLine("Entre a altura e a largura do retangulo: ");
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = " + x.Area().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("PERIMETRO = " + x.Perimetro().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("\n");
            // PROGRAMA FUNCIONARIO-------------------------------------------------------------------
            Funcionario func;
            func = new Funcionario();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario: " + func);
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double pctg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(pctg);
            Console.WriteLine("Dados atualizados: " + func);
            Console.WriteLine("\n");
            // PROGRAMA NOTAS ------------------------------------------------------------------------
            Aluno aluno1;
            aluno1 = new Aluno();
            int numerosAlunos = 0;
            while (numerosAlunos < 2)
            {
                Console.Write("Nome do aluno: ");
                aluno1.Nome = Console.ReadLine();
                Console.WriteLine("Digite as tres notas do aluno: ");
                aluno1.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno1.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno1.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("NOTA FINAL: " + aluno1.Media().ToString("F2", CultureInfo.InvariantCulture));
                if (aluno1.Aprovado())
                {
                    Console.WriteLine("APROVADO!");
                }
                else
                {
                    Console.WriteLine("REPROVADO!\nFALTARAM: " + aluno1.Falta().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
                }
                numerosAlunos++;
            }
            Console.ReadLine();
        }
    }
}
