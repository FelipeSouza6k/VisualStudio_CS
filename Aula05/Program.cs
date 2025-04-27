namespace Aula04;
public class Program
{
    public static void Main()
    {
        //Soma
        Console.WriteLine("===== CALCULADORA =====");
        Console.WriteLine("Digite o primeiro número: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Soma");
        int sum = number + number2;
        Console.WriteLine(sum);

        //Subtração
        Console.WriteLine("Subtração");
        int sub = number - number2;
        Console.WriteLine(sub);

        //Multiplicação
        Console.WriteLine("Multiplicação");
        int mult = number * number2;
        Console.WriteLine(mult);

        //Divisão
        Console.WriteLine("Divisão");
        double div = number / number2;
        Console.WriteLine(div);

        //Modulo = resto da divisão
        Console.WriteLine("Módulo");
        int mod = number % number2;
        Console.WriteLine(mod);


    }
}
