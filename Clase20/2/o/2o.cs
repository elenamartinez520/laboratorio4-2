namespace ConsoleApp2o
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                string numero;

                Console.Write("Numero: ");
                numero = Console.ReadLine();

                for (int i = 0; i < numero.Length; i++)
                {
                    Console.WriteLine(numero[i]);
                }
            
        }
    }
}
