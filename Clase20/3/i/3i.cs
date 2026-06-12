namespace ConsoleApp3i
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Palabra: ");
                string palabra = Console.ReadLine();

                for (int i = 0; i < palabra.Length; i++)
                {
                    int contador = 0;

                    for (int j = 0; j < palabra.Length; j++)
                    {
                        if (palabra[i] == palabra[j])
                        {
                            contador++;
                        }
                    }

                    Console.WriteLine(palabra[i] + ": " + contador);
                }
            
        }
    }
}
