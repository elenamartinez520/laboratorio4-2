namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int decenas;
            int unidades;
            int permutado;

            Console.WriteLine("Indicar un numero de dos cifras");

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 10 && numero <= 99)
            {
                decenas = numero / 10;
                unidades = numero % 10;

                permutado = (unidades * 10) + decenas;

                Console.WriteLine("Valor: " + numero);
                Console.WriteLine("Valor permutado: " + permutado);
            }
            else
            {
                Console.WriteLine("Numero incorrecto");
            }

        }
    }
}
