internal class Program
{
    private static void Main(string[] args)
    {
        int? age = 0;
        Console.WriteLine("Captura tu edad y presiona la tecla «ENTER»");
        string? agecapture = Console.ReadLine();
        if (agecapture is not null)
        {
            try
            {
                age = Convert.ToInt32(agecapture);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Reingrese el resultado con un formato correcto");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Reingrese el resultado con una edad válida");
            }
        }
        if (age>=0)
        {
            Console.WriteLine($"edad: {age}");
        }
        else
        {
            Console.WriteLine("Reingrese el resultado con un número positivo");
        }
        
    }
}