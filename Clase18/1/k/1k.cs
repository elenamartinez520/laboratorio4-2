namespace ConsoleApp1k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Numero: ");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine(num + " x " + i + " = " + (num * i));
                }
            
        }
    }
}
