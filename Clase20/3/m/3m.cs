namespace ConsoleApp3m
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Palabra: ");
                string palabra = Console.ReadLine();

                string texto = "";

                for (int i = 0; i < palabra.Length; i++)
                {
                    texto = texto + palabra[i];
                    Console.WriteLine(texto);
                }
            
        }
    }
}
