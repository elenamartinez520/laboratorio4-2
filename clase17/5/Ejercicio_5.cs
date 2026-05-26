namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fecha;
            int mes;

            Console.WriteLine("Indicar una fecha como un entero de 6 digitos");

            fecha = Convert.ToInt32(Console.ReadLine());

            mes = (fecha / 100) % 100;

            Console.WriteLine("Fecha: " + fecha);
            Console.WriteLine("Mes: " + mes);

        }
    }
}
