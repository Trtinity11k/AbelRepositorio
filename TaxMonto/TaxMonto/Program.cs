internal class Program
{
    private static void Main(string[] args)
    {
        // Diccionario que almacena los valores del IVA para cada país
        Dictionary<string, double> ivaImpuesto = new Dictionary<string, double>
        {
            { "AR", 21.00 },  // Argentina
            { "CL", 19.00 },  // Chile
            { "CO", 19.00 },  // Colombia
            { "DO", 18.00 },  // República Dominicana
            { "ES", 21.00 },  // España
            { "FR", 20.00 },  // Francia
            { "IT", 22.00 },  // Italia
            { "MX", 16.00 },  // México
            { "PE", 18.00 },  // Perú
            { "UK", 20.00 },  // Reino Unido
            { "US", 0.00 }    // Estados Unidos (sin IVA)
           
        };


        Console.WriteLine("***********************************");
        Console.WriteLine("*Introduce el monto total a pagar:*");
        Console.WriteLine("***********************************");

        double MontoPago = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("**************************************");
        Console.WriteLine("*Introduce la region del region code:*");
        Console.WriteLine("**************************************");
        Console.WriteLine("");
        Console.WriteLine("********************************************");
        Console.WriteLine("*Asegura que la entrada esté en mayúsculas:*");
        Console.WriteLine("********************************************");

        string regionCode = Console.ReadLine().ToUpper(); 
        

        if (ivaImpuesto.ContainsKey(regionCode))
        {
            
            
            double ivaRate = ivaImpuesto[regionCode];
            double taxMonto = MontoPago * (ivaRate / 100);
            double Total = MontoPago + taxMonto;
            Console.WriteLine($"El Impuesto hace un total de: {taxMonto}, El total a pagar es: {Total}.");
        }
        else
        {
            Console.WriteLine("La region que ha ingresado no existe.");
        }
    }
}