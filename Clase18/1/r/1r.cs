namespace ConsoleApp1r
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string frase;
                int contador = 0;

                Console.Write("Frase: ");
                frase = Console.ReadLine();

                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == 'a')
                    {
                        contador++;
                    }
                }

                Console.WriteLine(contador);
            
        }
    }
}
