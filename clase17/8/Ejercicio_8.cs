namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit;
            int centigrados;

            Console.WriteLine("Ingrese temperatura (Fahrenheit)");

            fahrenheit = Convert.ToInt32(Console.ReadLine());

            centigrados = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Temperatura en centigrados: " + centigrados);

        }
    }
}
