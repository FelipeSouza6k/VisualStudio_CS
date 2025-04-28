namespace Aula08;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Operadores Relacionais\n");
        Console.WriteLine("Digite o Primeiro número\n");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o Segundo número\n");
        int y = Convert.ToInt32(Console.ReadLine());

        //Operador de Igualdade (==)
        if (x == y)
        {
            Console.WriteLine("Os números são iguais\n");
        }
        //Operador de Diferença (!=) 
        if (x != y)
        {
            Console.WriteLine("Os números são diferentes\n");
        }
        //Operador Menor que
        if (x < y)
        {
            Console.WriteLine("X é menor que Y\n");
        }
        //Operador Maior que
        if (x > y)
        {
            Console.WriteLine("X é maior que Y\n");
        }
        //Operador Menor ou igual a
        if (x <= y)
        {
            Console.WriteLine("X é menor ou igual a Y\n");
        }
        //Operador Maior ou igual a
        if (x >= y)
        {
            Console.WriteLine("X é maior ou igual a Y\n");
        }

    }
}

