namespace ConsoleApp3e
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int numero = 1;
                int contador = 0;

                while (contador < 50)
                {
                    if ((numero % 2 == 0 && numero % 5 != 0) ||
                        (numero % 5 == 0 && numero % 2 != 0))
                    {
                        Console.WriteLine(numero);
                        contador++;
                    }

                    numero++;
                }
            

        }
    }
}
