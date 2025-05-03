public class Program
{
    public static void Main()
    {
        //Coleções (listas)
        List<int> numberList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach(int number in numberList)
        {
            Console.WriteLine(number);

        }
        List<string> stringList = new List<string>() { "Rodrigo", "Felipe", "Valkiria", "Sabonete", "Luan", "Porta" };
        foreach(string lista in stringList)
        {
            Console.WriteLine(lista);
        }
    }
}