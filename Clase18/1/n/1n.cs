namespace ConsoleApp1n
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine("Puede votar y manejar");
                }
                else if (edad >= 16)
                {
                    Console.WriteLine("Puede votar");
                }
                else
                {
                    Console.WriteLine("No puede ninguna");
                }
            
        }
    }
}
