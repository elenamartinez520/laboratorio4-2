namespace ConsoleApp2r
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                double suma = 0;
                double mejorNota = 0;
                string mejorAlumno = "";

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Nota: ");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    suma = suma + nota;

                    if (nota > mejorNota)
                    {
                        mejorNota = nota;
                        mejorAlumno = nombre;
                    }
                }

                Console.WriteLine("Promedio: " + (suma / 5));
                Console.WriteLine("Mejor alumno: " + mejorAlumno);
            
        }
    }
}
