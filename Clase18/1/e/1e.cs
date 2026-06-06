namespace ConsoleApp1e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Numero: ");
                int mayor = Convert.ToInt32(Console.ReadLine());

                for (int i = 2; i <= 10; i++)
                {
                    Console.Write("Numero: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num > mayor)
                    {
                        mayor = num;
                    }
                }

                Console.WriteLine("Mayor: " + mayor);
            
        }
    }
}
