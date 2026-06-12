namespace ConsoleApp3k
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Numero: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0 && num <= 25)
                {
                    Console.WriteLine("0-25");
                }
                else if (num <= 50)
                {
                    Console.WriteLine("26-50");
                }
                else if (num <= 75)
                {
                    Console.WriteLine("51-75");
                }
                else if (num <= 100)
                {
                    Console.WriteLine("76-100");
                }
            
        }
    }
}
