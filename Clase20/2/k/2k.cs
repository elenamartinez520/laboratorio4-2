namespace ConsoleApp2k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string[] nombres = new string[100];

                int cantidad = 0;
                bool repetido = false;

                while (repetido == false)
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    for (int i = 0; i < cantidad; i++)
                    {
                        if (nombres[i] == nombre)
                        {
                            repetido = true;
                        }
                    }

                    if (repetido == false)
                    {
                        nombres[cantidad] = nombre;
                        cantidad++;
                    }
                }

                Console.WriteLine("Ingresados: " + cantidad);
            
        }
    }
}
