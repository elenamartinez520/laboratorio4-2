namespace ConsoleApp1f
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                Console.Write("Nombre completo: ");
                string nombre = Console.ReadLine().ToLower();

                string resultado = "";

                for (int i = 0; i < nombre.Length; i++)
                {
                    if (i == 0)
                    {
                        resultado = resultado + nombre[i].ToString().ToUpper();
                    }
                    else if (nombre[i - 1] == ' ')
                    {
                        resultado = resultado + nombre[i].ToString().ToUpper();
                    }
                    else
                    {
                        resultado = resultado + nombre[i];
                    }
                }

                Console.WriteLine("Hola " + resultado);
            

        }
    }
}
