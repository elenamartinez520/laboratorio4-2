namespace ConsoleApp3j
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string usuarioCorrecto = "elena";
                string contraseñaCorrecta = "1234";

                int intentos = 0;

                while (intentos < 3)
                {
                    Console.Write("Usuario: ");
                    string usuario = Console.ReadLine();

                    Console.Write("Contraseña: ");
                    string contraseña = Console.ReadLine();

                    if (usuario == usuarioCorrecto &&
                        contraseña == contraseñaCorrecta)
                    {
                        Console.WriteLine("Bienvenido");
                        return;
                    }

                    intentos++;
                }

                Console.WriteLine("Acceso denegado");
            
        }
    }
}
