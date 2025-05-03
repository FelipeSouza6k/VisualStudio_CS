public class Program
{
    public static void Main()
    {
        //Declaração de um array de strings
        string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };

        Console.WriteLine(fruits[1] + "\n\n\n\n\n\n");

        Console.WriteLine("Utilizando o foreach(abaixo)");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
