namespace ConsoleApp2l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                for (int i = 100; i <= 200; i++)
                {
                    if (i % 7 == 0 && i % 10 == 3)
                    {
                        Console.WriteLine(i);
                    }
                }
            
        }
    }
}
