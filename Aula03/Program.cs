namespace Aula03;
public class Program
{
    public static void Main()
    {
        int number = 30;
        number = 20;
        number = 10;
        Console.WriteLine(number);
        number = 5;
        Console.WriteLine("Agora o valor é = " + number);

        var text = "Olá mundo";
        // Não pode ser atribuido um número inteiro a variável text, pois, ela já foi declarada como String.
        text = 500;
        //
        const int max = 10000;
        //Variável max não pode ser mudada pois é uma constante
        max = 999;
        //
        Console.WriteLine(max);


        //A váriável pode ser mudada de string para int por conta do tipo dynamic
        dynamic dinamica = "Olá";
        Console.WriteLine(dinamica);
        dinamica = 300;
        //

    }
}
