namespace ConsoleApp3c
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Palabra: ");
                string palabra = Console.ReadLine();

                Console.Write("Letra: ");
                string letra = Console.ReadLine();

                int contador = 0;

                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == letra[0])
                    {
                        contador++;
                    }
                }

                Console.WriteLine("Aparece " + contador + " veces");
           

        }
    }
}
