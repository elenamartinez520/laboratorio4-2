namespace ConsoleApp1q
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                string nombre;

                do
                {
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();

                } while (nombre.Length <= 10);
            
        }
    }
}
