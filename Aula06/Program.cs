using System.ComponentModel.Design;

namespace Aula06;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Estruturas Condicionais ");
        Console.WriteLine("Digite a idade de uma pessoa e veja se ela esta apta para votar\n");
        Console.WriteLine("Digite a idade:\n");
        int idade = Convert.ToInt32(Console.ReadLine());
        if (idade < 16)
        {
            Console.WriteLine("Esta pessoa não esta apta para votar.");
        }
        else if (idade < 18 || idade >= 60)
        {
            Console.WriteLine("Está pessoa pode votar, mas não é obrigatório.");
        }
        else if (idade >= 18 && idade < 60)
        {
            Console.WriteLine("Esta pessoa é obrigada a votar.");
        }
    }
    
}