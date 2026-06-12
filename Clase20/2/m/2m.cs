namespace ConsoleApp2m
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                double total = 0;
                int productos = 0;

                while (total <= 1000)
                {
                    Console.Write("Precio: ");
                    total = total + Convert.ToDouble(Console.ReadLine());

                    productos++;
                }

                Console.WriteLine("Productos: " + productos);
            
        }
    }
}
