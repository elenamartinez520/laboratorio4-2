namespace ConsoleApp1j
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
                    if (frase[i] == 'a' || frase[i] == 'e' ||
                        frase[i] == 'i' || frase[i] == 'o' ||
                        frase[i] == 'u')
                    {
                        contador++;
                    }
                }

                Console.WriteLine(contador);
            
        }
    }
}
