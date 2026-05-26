namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int central;

            Console.WriteLine("Indicar un numero de tres cifras");

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 100 && numero <= 999)
            {
                central = (numero / 10) % 10;

                Console.WriteLine("Valor: " + numero);
                Console.WriteLine("La cifra central es: " + central);
            }
            else
            {
                Console.WriteLine("Numero incorrecto");
            }



        }


    }

}

