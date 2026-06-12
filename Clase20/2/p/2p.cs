namespace ConsoleApp2p
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Random r = new Random();

                int usuario = 0;
                int maquina = 0;

                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Ronda " + i);
                    Console.WriteLine("1-Piedra");
                    Console.WriteLine("2-Papel");
                    Console.WriteLine("3-Tijera");

                    int jugada = Convert.ToInt32(Console.ReadLine());

                    int pc = r.Next(1, 4);

                    Console.WriteLine("La maquina eligio: " + pc);

                    if ((jugada == 1 && pc == 3) ||
                        (jugada == 2 && pc == 1) ||
                        (jugada == 3 && pc == 2))
                    {
                        Console.WriteLine("Ganaste la ronda");
                        usuario++;
                    }
                    else if (jugada == pc)
                    {
                        Console.WriteLine("Empate");
                    }
                    else
                    {
                        Console.WriteLine("Gano la maquina");
                        maquina++;
                    }
                }

                Console.WriteLine("Puntos usuario: " + usuario);
                Console.WriteLine("Puntos maquina: " + maquina);

                if (usuario > maquina)
                {
                    Console.WriteLine("Ganaste el juego");
                }
                else if (maquina > usuario)
                {
                    Console.WriteLine("Gano la maquina");
                }
                else
                {
                    Console.WriteLine("Empate final");
                }
            

        }
    }
}
