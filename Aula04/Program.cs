public class Program
{
    public static void Main()
    {
        Console.WriteLine("-----CADASTRO DE CLIENTES-----");
        //Solicitar nome do usúario
        Console.WriteLine("Digite o seu nome: \n");
        string name = Console.ReadLine();

        //Solicitar idade do usúario
        Console.WriteLine("\nDigite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\nInformações do usúario\n\n");
        Console.WriteLine($"O nome do usúario é {name}");
        Console.WriteLine($"O usuário tem {age} anos de idade ");

    }
}