namespace ConsoleApp2h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string respuesta;

                do
                {
                    Console.Write("Celsius: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    double f = (c * 9 / 5) + 32;

                    Console.WriteLine("Fahrenheit: " + f);

                    Console.Write("Continuar si/no: ");
                    respuesta = Console.ReadLine();

                } while (respuesta == "si");
            
        }
    }
}
