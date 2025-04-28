namespace Aula10;

public class Program
{
    public static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("-----CALCULADORA-----");
            Console.WriteLine("Digite o primeiro número:\n");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:\n");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação:\n");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            string operation = Console.ReadLine();
            //ADIÇÃO
            if (operation == "1")
            {
                Console.WriteLine("Resultado: " + (num1 + num2));
            }
            //SUBTRAÇÃO
            else if (operation == "2")
            {
                Console.WriteLine("Resultado: " + (num1 - num2));
            }
            //MULTIPLICAÇÃO
            else if (operation == "3")
            {
                Console.WriteLine("Resultado:" + (num1 * num2));
            }
            //DIVISÃO
            else if (operation == "4")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    return;
                }
                else
                {
                    Console.WriteLine("Resultado: " + (num1 / num2));
                }
                //Perguntar se o usúario deseja continuar
            }
            Console.WriteLine("Você deseja continuar? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta != "s")
            {
                continuar = false;
                Console.WriteLine("Obrigado por usar a calculadora!");
            }
        }
    }
}
