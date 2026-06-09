namespace ConsoleApp3g
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Random r = new Random();

                int secreto = r.Next(1, 101);
                int numero;
                int intentos = 0;

                do
                {
                    Console.Write("Numero: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    intentos++;

                    if (numero < secreto)
                    {
                        Console.WriteLine("Mas grande");
                    }
                    else if (numero > secreto)
                    {
                        Console.WriteLine("Mas chico");
                    }

                } while (numero != secreto);

                Console.WriteLine("Intentos: " + intentos);
           
        }
    }
}
