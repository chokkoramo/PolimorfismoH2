class Program
{
    static void Main(string[] args)
    {
        FiguraGeometrica figura1 = new Circulo(5);
        FiguraGeometrica figura2 = new Elipse(2, 6);
        FiguraGeometrica figura3 = new Esfera(7);

        Console.WriteLine("|-------------------------------------|");
        Console.WriteLine("| - - - - - Area y Diametro - - - - - |");
        Console.WriteLine("|-------------------------------------|");
        Console.WriteLine("|              CIRCULO                |");
        Console.WriteLine("| → Área del círculo: " + figura1.CalcularArea());
        Console.WriteLine("| → Diámetro del círculo: " + figura1.CalcularDiametro());
        Console.WriteLine("|-------------------------------------|");
        Console.WriteLine("|               ELIPSE                |");
        Console.WriteLine("| → Área de la elipse: " + figura2.CalcularArea());
        Console.WriteLine("| → Diámetro de la elipse: " + figura2.CalcularDiametro());
        Console.WriteLine("|-------------------------------------|");
        Console.WriteLine("|               ESFERA                |");
        Console.WriteLine("| → Área de la esfera: " + figura3.CalcularArea());
        Console.WriteLine("| → Diámetro de la esfera: " + figura3.CalcularDiametro());
        Console.WriteLine("|-------------------------------------|");
    }
}