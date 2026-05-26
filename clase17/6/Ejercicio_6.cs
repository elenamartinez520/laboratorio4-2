namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lado;
            float perimetro;
            float superficie;

            Console.WriteLine("Ingrese el lado del cuadrado");

            lado = Convert.ToSingle(Console.ReadLine());

            perimetro = lado * 4;
            superficie = lado * lado;

            Console.WriteLine("Perimetro: " + perimetro);
            Console.WriteLine("Superficie: " + superficie);

        }
    }
}
