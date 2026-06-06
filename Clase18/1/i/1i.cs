namespace ConsoleApp1i
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Numero: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("Par");
                }
                else
                {
                    Console.WriteLine("Impar");
                }
            
        }
    }
}
