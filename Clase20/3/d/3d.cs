namespace ConsoleApp3d
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                double saldo = 1000;
                int opcion;

                do
                {
                    Console.WriteLine("Saldo: " + saldo);
                    Console.WriteLine("1 Depositar");
                    Console.WriteLine("2 Retirar");
                    Console.WriteLine("3 Salir");

                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Console.Write("Monto: ");
                        saldo += Convert.ToDouble(Console.ReadLine());
                    }
                    else if (opcion == 2)
                    {
                        Console.Write("Monto: ");
                        double retiro = Convert.ToDouble(Console.ReadLine());

                        if (retiro <= saldo)
                        {
                            saldo -= retiro;
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente");
                        }
                    }

                } while (opcion != 3);
            
        }
    }
}
