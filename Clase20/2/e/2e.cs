namespace ConsoleApp2e
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Numero: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int factorial = 1;

                for (int i = 1; i <= num; i++)
                {
                    factorial = factorial * i;
                }

                Console.WriteLine(factorial);
            
        }
    }
}
