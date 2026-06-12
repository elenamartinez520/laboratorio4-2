namespace ConsoleApp1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                if (edad < 18)
                {
                    Console.WriteLine("Menor de edad");
                }
                else if (edad == 18)
                {
                    Console.WriteLine("Tiene justo 18");
                }
                else
                {
                    Console.WriteLine("Mayor de edad");
                }
           
        }
    }
}
