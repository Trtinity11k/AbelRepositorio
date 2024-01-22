using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("************************");
        Console.WriteLine("* Tabla de Multiplicar *");
        Console.WriteLine("************************");

        Console.WriteLine("*************************************");
        Console.WriteLine("* Introducir el numero a multiplicar*");
        Console.WriteLine("*************************************");
        int a = 0;
        int Inicio = 0;
        int Rango = 0;
        a = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("************************************************");
        Console.WriteLine("*Ingrese el rango para la tabla de multiplicar:*");
        Console.WriteLine("************************************************");
        Rango = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("***************************");
        Console.WriteLine($"Tabla de Multipliar del: {a}*");
        Console.WriteLine("***************************");
        Console.WriteLine();
        for (int i = 0; i <= Rango; i++)
        {
            int resultado = a * i;
            Console.WriteLine($"{a} x {i} = {resultado}");
        }
    }
}