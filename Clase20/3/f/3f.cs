namespace ConsoleApp3f
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                string abc = "abcdefghijklmnopqrstuvwxyz";

                Console.Write("Palabra: ");
                string palabra = Console.ReadLine();

                for (int i = 0; i < palabra.Length; i++)
                {
                    for (int j = 0; j < abc.Length; j++)
                    {
                        if (palabra[i] == abc[j])
                        {
                            Console.WriteLine(j + 1);
                        }
                    }
                }
           
        }
    }
}
