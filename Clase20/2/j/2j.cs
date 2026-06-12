namespace ConsoleApp2j
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string[] nombres = new string[100];
                int cantidad = 0;
                string nombre;

                do
                {
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();

                    if (nombre != "fin")
                    {
                        nombres[cantidad] = nombre;
                        cantidad++;
                    }

                } while (nombre != "fin");

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Hola " + nombres[i]);
                }
            

        }
    }
}
