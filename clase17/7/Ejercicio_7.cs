namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorHora;
            float horas;
            float sueldo;

            Console.WriteLine("Ingrese valor por hora");

            valorHora = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese horas trabajadas");

            horas = Convert.ToSingle(Console.ReadLine());

            sueldo = valorHora * horas;

            Console.WriteLine("Sueldo bruto: $" + sueldo);

        }
    }
}
