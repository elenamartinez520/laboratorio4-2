namespace ConsoleApp2f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string[] nombres = new string[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Nombre: ");
                    nombres[i] = Console.ReadLine();
                }

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Turno " + (i + 1) + ": " + nombres[i]);
                }
            
        }
    }
}
