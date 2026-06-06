namespace ConsoleApp2s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

                for (int i = abecedario.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(abecedario[i]);
                }
            
        }
    }
}
