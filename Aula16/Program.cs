using System.Globalization;

public class Program
{
    public static void Main()
    {
        //1. Declaração de um array de strings. (Inicializando com valores)
        string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
        string separator = ("------------------");


        //2. Acessando o array
        Console.WriteLine(fruits[1]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);

        }
        Console.WriteLine(separator);

        //3. Contar Indíces
        Console.WriteLine("Quantidade de Indíces: " + fruits.Length);

        Console.WriteLine(separator);

        //4. Alterar os valores
        Console.WriteLine("Valor antes da alteração: " + fruits[1]);
        fruits[1] = "Abacaxi";
        Console.WriteLine("Valor depois da alteração: " + fruits[1]);

        //5. Declaração de um array (sem a inicialização)
        int[] ints = new int[10];
        ints[0] = 10;
        ints[1] = 20;
        ints[2] = 30;

        foreach (int number in ints)
        {
            Console.WriteLine(number);
        }



    }
}
