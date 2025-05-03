public class Program
{
    public static void Main()
    {
        Console.WriteLine("TEMPORIZADOR");
        Console.WriteLine("Digite o tempo em horas: ");

        int horas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o tempo em minutos: ");

        int minutos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o tempo em segundos: ");

        int segundos = Convert.ToInt32(Console.ReadLine());


        for (int decrementoHoras = horas;  horas > -1; horas--)
        {
            for (int decrementoMinutos = minutos; minutos > -1; minutos--)
            {
                for (int decrementoSegundos = segundos; segundos > -1; segundos--)
                {
                    Console.WriteLine($"{horas} : {minutos} : {segundos}");
                }
                segundos = 59;
            }
            minutos = 59;
        }
    }
}
