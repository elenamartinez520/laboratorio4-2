namespace ConsoleApp3l
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double imc = peso / (altura * altura);

                Console.WriteLine("IMC: " + imc);

                if (imc < 18.5)
                {
                    Console.WriteLine("Bajo peso");
                }
                else if (imc < 25)
                {
                    Console.WriteLine("Normal");
                }
                else if (imc < 30)
                {
                    Console.WriteLine("Sobrepeso");
                }
                else
                {
                    Console.WriteLine("Obesidad");
                }
            
        }
    }
}
