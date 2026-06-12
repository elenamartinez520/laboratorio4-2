namespace ConsoleApp3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Numero: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 1)
                {
                    Console.WriteLine("No se puede");
                }
                else
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}
