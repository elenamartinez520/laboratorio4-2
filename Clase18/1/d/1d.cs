namespace ConsoleApp1d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string contraseña = "1234";
                string intento;
                int intentos = 0;

                while (intentos < 5)
                {
                    Console.Write("Contraseña: ");
                    intento = Console.ReadLine();

                    if (intento == contraseña)
                    {
                        Console.WriteLine("Correcta");
                        return;
                    }

                    intentos++;
                }

                Console.WriteLine("Sin intentos");
           
        }
    }
}
