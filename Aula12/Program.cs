public class Program
{
    public static void Main()
    {
        //       int i = 0;
        //     while(i <= 5){
        //       Console.WriteLine(i);
        //     i++;
        //}
        int bullet = 100;
        while (bullet > 0)
        {
            Console.WriteLine("Você tem " + bullet + " munições retantes.");
            bullet--;
        }
    }
}