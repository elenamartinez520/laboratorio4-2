namespace ConsoleApp3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int opcion1 = 0;
                int opcion2 = 0;
                int opcion3 = 0;

                string voto;

                do
                {
                    Console.WriteLine("Opcion1");
                    Console.WriteLine("Opcion2");
                    Console.WriteLine("Opcion3");
                    Console.WriteLine("Escriba terminar para finalizar");

                    voto = Console.ReadLine();

                    if (voto == "1")
                    {
                        opcion1++;
                    }
                    else if (voto == "2")
                    {
                        opcion2++;
                    }
                    else if (voto == "3")
                    {
                        opcion3++;
                    }

                } while (voto != "terminar");

                if (opcion1 > opcion2 && opcion1 > opcion3)
                {
                    Console.WriteLine("Gano opcion 1");
                }
                else if (opcion2 > opcion1 && opcion2 > opcion3)
                {
                    Console.WriteLine("Gano opcion 2");
                }
                else if (opcion3 > opcion1 && opcion3 > opcion2)
                {
                    Console.WriteLine("Gano opcion 3");
                }
                else
                {
                    Console.WriteLine("Empate");
                }
            
        }
    }
}
