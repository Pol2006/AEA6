public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Introdueixi el valor: ");
        int valor;
        if (int.TryParse(System.Console.ReadLine(), out valor))
        {
            var multiples = Metodes.comptadorMultiples(valor);
            System.Console.WriteLine("Hi ha " + multiples.Count + " nombres múltiples de 7 més petits de " + valor + ".");
            if (multiples.Count > 0)
            {
                System.Console.WriteLine("Els múltiples són: " + string.Join(", ", multiples));
            }
        }
        else
        {
            System.Console.WriteLine("Valor no valid.");
        }
    }
}

public class Metodes
{
    public static List<int> comptadorMultiples(int valor)
    {
        var multiples = new List<int>();
        for (int i = 7; i < valor; i += 7)
        {
            multiples.Add(i);
        }
        return multiples;
    }
}
