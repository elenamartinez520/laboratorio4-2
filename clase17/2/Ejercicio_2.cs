namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float precio;
            float descuento;
            float final;

            Console.WriteLine("Indicar precio de lista");

            precio = Convert.ToSingle(Console.ReadLine());

            descuento = precio * 18 / 100;
            final = precio - descuento;

            Console.WriteLine("Precio de lista: $" + precio);
            Console.WriteLine("Descuento: 18%");
            Console.WriteLine("Precio con descuento: $" + final);
        }


    }
}

