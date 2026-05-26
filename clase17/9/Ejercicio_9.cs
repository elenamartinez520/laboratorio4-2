namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h1;
            int m1;
            int s1;

            int h2;
            int m2;
            int s2;

            int tiempo1;
            int tiempo2;
            int diferencia;

            Console.WriteLine("Primer instante");

            Console.WriteLine("Hora");
            h1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minutos");
            m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundos");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo instante");

            Console.WriteLine("Hora");
            h2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minutos");
            m2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundos");
            s2 = Convert.ToInt32(Console.ReadLine());

            tiempo1 = (h1 * 3600) + (m1 * 60) + s1;
            tiempo2 = (h2 * 3600) + (m2 * 60) + s2;

            diferencia = tiempo2 - tiempo1;

            Console.WriteLine("Cantidad de segundos: " + diferencia);

        }
    }
}
