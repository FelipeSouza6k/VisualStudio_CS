namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Operadores Lógicos");

        bool isLogged = true;
        bool hasAdminAcess = false;

        Console.WriteLine("Informações do Usúario");
        Console.WriteLine($"Logado: {isLogged}");
        Console.WriteLine($"Acesso Admin: {hasAdminAcess}");
        //Operador Logico AND (&&)
        if (isLogged && hasAdminAcess)
        {
            Console.WriteLine("Acesso ao sistema");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }

        //Operador Logico OR (||)
        if (isLogged || hasAdminAcess)
        {
            Console.WriteLine("Acesso ao sistema concedido");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
        if (!isLogged)
        {
            Console.WriteLine("Usuário não logado");
        }
        else
        {
            Console.WriteLine("Usuário logado");
        }
    }
}
