using System;
using System.Globalization;

namespace Exercicio
{
    class ProjetoTres
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro pequeno: ");
            sbyte numero1 = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Digite um único caracter: ");
            char letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número real: ");
            float numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva algo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite outro caracter: ");
            char letra2 = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro pequeno: ");
            sbyte numero3 = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Digite novamente um número real: ");
            float numero4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um nome, um único caracter, um número inteiro pequeno, um número real, sempre com um espaço entre eles: ");
            string[] v = Console.ReadLine().Split(' ');
            string nome2 = v[0];
            char letra3 = char.Parse(v[1]);
            sbyte numero5 = sbyte.Parse(v[2]);
            float numero6 = float.Parse(v[3]);


            Console.WriteLine(numero1);
            Console.WriteLine(letra1);
            Console.WriteLine(numero2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(letra2);
            Console.WriteLine(numero3);
            Console.WriteLine(numero4.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome2);
            Console.WriteLine(letra3);
            Console.WriteLine(numero5);
            Console.WriteLine(numero6.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}