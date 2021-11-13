using System;
using System.Globalization;

namespace AppMediaSalarioFuncionario
{
    class Program
    {
        public static double mediaSalario(double salario01, double slario02) 
        {
            double media;
            return media = (salario01 + slario02) / 02;
        }

        static void Main(string[] args)
        {
            Funcionario funcionario01 = new Funcionario();
            Funcionario funcionario02 = new Funcionario();

            Console.WriteLine("Entre com o nome e salario do primeiro funcionario: ");
            string[] vet = Console.ReadLine().Split(" ");

            Console.WriteLine("Entre com o nome e salario do segundo funcionario: ");
            string[] vet2 = Console.ReadLine().Split(" ");

            funcionario01.nome = vet[0];
            funcionario01.salario = double.Parse(vet[2]);

            funcionario02.nome = vet2[0];
            funcionario02.salario = double.Parse(vet2[2]);
            
            double media = mediaSalario(funcionario01.salario, funcionario02.salario);

            Console.WriteLine("O salario médio é: {0} R$", media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
