namespace ConsoleApp1l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int suma = 0;

                while (suma <= 100)
                {
                    Console.Write("Numero: ");
                    suma = suma + Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Total: " + suma);
            
        }
    }
}
