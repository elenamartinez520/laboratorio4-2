namespace ConsoleApp3h
{
    internal class Program
    {
        static void Main(string[] args)
        {
                 Console.Write("Frase: ");
                string frase = Console.ReadLine();

                string palabra = "";

                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] != ' ')
                    {
                        palabra = frase[i] + palabra;
                    }
                    else
                    {
                        Console.Write(palabra + " ");
                        palabra = "";
                    }
                }

                Console.WriteLine(palabra);
            
        }
    }
}
