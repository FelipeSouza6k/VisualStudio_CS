namespace Aula07;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Operadores de atribuição\n");
        int a = 10;
        Console.WriteLine($"a = {a}");

        //Operador de atribuição
        a = 20;
        Console.WriteLine($"\na = {a}");
        //Operador (++)
        a++; // a = 21
        Console.WriteLine($"\na = {a}");
        //(a+=)
        a += 10; // a = 31
        Console.WriteLine($"\na = {a}");

        a-= 10; // a = 21
        Console.WriteLine($"\na = {a}");

    }
}
