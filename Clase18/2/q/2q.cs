namespace ConsoleApp2q
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

                int contador = 0;

                for (int i = 1; i <= 10; i++)
                {
                    int numero = r.Next(1, 101);

                    Console.WriteLine(numero);

                    if (numero > 50)
                    {
                        contador++;
                    }
                }

                Console.WriteLine("Mayores a 50: " + contador);
            
        }
    }
}
