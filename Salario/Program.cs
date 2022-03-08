using System;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Funcionario: ");
            var nome = Console.ReadLine();

            Console.WriteLine("\nAgora digite o salário desse funcionario: ");
            var salario = float.Parse(Console.ReadLine());

            Console.WriteLine($"\nAtualmente o salário do(a) {nome} é R${salario.ToString("F2")}.");

            if (salario <= 200)
                Console.WriteLine($"\nO salario do(a) {nome} não sera reajustado.");

            else if (salario <= 400)
            {
                var aumento = salario * 0.2;
                Console.WriteLine($"\nO salário do(a) {nome} terá um reajuste de R${aumento.ToString("F2")}(20%), e passará a ser R${(salario + aumento).ToString("F2")}");
            }
            else if (salario <= 600)
            {
                var aumento = salario * 0.3;
                Console.WriteLine($"\nO salário do(a) {nome} terá um reajuste de R${aumento.ToString("F2")}(30%), e passará a ser R${(salario + aumento).ToString("F2")}");
            }

            else
            {
                var aumento = salario * 0.4;
                Console.WriteLine($"\nO salário do(a) {nome} terá um reajuste de R${aumento.ToString("F2")}(40%), e passará a ser R${(salario + aumento).ToString("F2")}");
            }          
        }
    }
}
