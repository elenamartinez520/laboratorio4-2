namespace ConsoleApp2n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string nombre;
                string mail;
                int edad;

                Console.Write("Nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Edad: ");
                bool edadValida = int.TryParse(Console.ReadLine(), out edad);

                Console.Write("Mail: ");
                mail = Console.ReadLine();

                bool tieneArroba = false;

                for (int i = 0; i < mail.Length; i++)
                {
                    if (mail[i] == '@')
                    {
                        tieneArroba = true;
                    }
                }

                if (edadValida && tieneArroba)
                {
                    Console.WriteLine("Correcto");
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                }
            
        }
    }
}
