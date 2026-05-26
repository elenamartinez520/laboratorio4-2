namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int unidades;
            int decenas;
            int centenas;

            Console.WriteLine("Ingrese un numero de tres cifras");

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 100 && numero <= 999)
            {
                unidades = numero % 10;
                decenas = (numero / 10) % 10;
                centenas = numero / 100;

                Console.WriteLine("Valor ingresado: " + numero);
                Console.WriteLine("Unidades: " + unidades);
                Console.WriteLine("Decenas: " + decenas);
                Console.WriteLine("Centenas: " + centenas);
            }
            else
            {
                Console.WriteLine("Numero incorrecto");
            }

        }
    }
}
