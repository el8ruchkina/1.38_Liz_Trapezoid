using System;
public class Mainclass
{
    public static void Main()
    {
        double a, b, h, c, p;
        Console.WriteLine("Введите меньшее основание:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите большее основание:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите высоту:");
        h = double.Parse(Console.ReadLine());
        c = Math.Sqrt(Math.Pow((b - a) / 2, 2) + Math.Pow(h, 2));
        p = (2 * c) + a + b;
        Console.WriteLine($"Периметр трапеции равен {p}");
    }
}