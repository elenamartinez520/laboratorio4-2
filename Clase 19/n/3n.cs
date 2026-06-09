namespace ConsoleApp3n
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string frase;

                do
                {
                    Console.Write("Frase: ");
                    frase = Console.ReadLine();

                    if (frase != "agusfortnite2008")
                    {
                        string[] vocales = { "a", "e", "i", "o", "u" };

                        for (int i = 0; i < 5; i++)
                        {
                            string nueva = frase;

                            nueva = nueva.Replace("a", vocales[i]);
                            nueva = nueva.Replace("e", vocales[i]);
                            nueva = nueva.Replace("i", vocales[i]);
                            nueva = nueva.Replace("o", vocales[i]);
                            nueva = nueva.Replace("u", vocales[i]);

                            Console.WriteLine(nueva);
                        }
                    }

                } while (frase != "agusfortnite2008");
            
        }
    }
}
