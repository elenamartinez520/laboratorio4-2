namespace ConsoleApp1p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string c1;
                string c2;

                do
                {
                    Console.Write("Contraseña: ");
                    c1 = Console.ReadLine();

                    Console.Write("Repetir: ");
                    c2 = Console.ReadLine();

                } while (c1 != c2);

                Console.WriteLine("Acceso permitido");
            
        }
    }
}
