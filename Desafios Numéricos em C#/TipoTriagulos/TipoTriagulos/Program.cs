using System;

class Desafio
{

    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        double a = double.Parse(s[0]);
        double b = double.Parse(s[1]);
        double c = double.Parse(s[2]);
        double temp;

        if (a < b) { temp = a; a = b; b = temp; }
        if (a < c) { temp = a; a = c; c = temp; }
        if (b < c) { temp = b; b = c; c = temp; }




        if (a >= b + c)
            Console.WriteLine("NAO FORMA TRIANGULO");
        else if (a * a == b * b + c * c)
            Console.WriteLine("TRIANGULO RETANGULO");
        else if (a * a > b * b + c * c)
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        else if (a * a < b * b + c * c)
            Console.WriteLine("TRIANGULO ACUTANGULO");
        if (a == b && a == c && b == c)
            Console.WriteLine("TRIANGULO EQUILATERO");
        else if (a == b || a == c || b == c)
            Console.WriteLine("TRIANGULO ISOSCELES");

        Console.ReadLine();
    }
}