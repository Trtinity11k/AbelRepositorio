internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el número hasta el cual desea generar los números ordinales:");
        int Meta = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= Meta; i++)
        {
            Console.WriteLine($"{i}{CardinalToOrdinal(i)}");
        }

        static string CardinalToOrdinal(int number)
        {
            if (number <= 0)
            {
                return number.ToString();
            }

            // Esta es la formula que encontre en internet
            if (number % 100 >= 11 && number % 100 <= 13)
            {
                return "th";
            }

            switch (number % 10)
            {
                case 1:
                    return "st";
                case 2:
                    return "nd";
                case 3:
                    return "rd";
                default:
                    return "th";
            }
        }
    }
 }