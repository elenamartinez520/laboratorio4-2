namespace ConsoleApp2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Random r = new Random();

                int secreto = r.Next(1, 11);
                int num;

                do
                {
                    Console.Write("Ingrese un numero: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num < secreto)
                    {
                        Console.WriteLine("Mas grande");
                    }
                    else if (num > secreto)
                    {
                        Console.WriteLine("Mas chico");
                    }

                } while (num != secreto);

                Console.WriteLine("Adivinaste");
            
        }
    }
}
