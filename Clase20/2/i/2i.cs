namespace ConsoleApp2i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Numero: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int contador = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine("Es primo");
                }
                else
                {
                    Console.WriteLine("No es primo");
                }
        }
    }
}
