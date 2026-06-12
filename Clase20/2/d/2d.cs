namespace ConsoleApp2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("1-Suma");
                Console.WriteLine("2-Resta");
                Console.WriteLine("3-Multiplicacion");
                Console.WriteLine("4-Division");

                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.Write("Numero 1: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Numero 2: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine(n1 + n2);
                }
                else if (opcion == 2)
                {
                    Console.WriteLine(n1 - n2);
                }
                else if (opcion == 3)
                {
                    Console.WriteLine(n1 * n2);
                }
                else if (opcion == 4)
                {
                    Console.WriteLine(n1 / n2);
                }
            
        }
    }
}
