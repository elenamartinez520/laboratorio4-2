namespace ConsoleApp1m
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Palabra: ");
                string palabra = Console.ReadLine();

                for (int i = 0; i < palabra.Length; i++)
                {
                    Console.WriteLine(palabra[i]);
                }
            
        }
    }
}
