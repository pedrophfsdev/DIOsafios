using System;

class Program
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');

        var a = int.Parse(vet[0]);
        var b = int.Parse(vet[1]);
        var c = int.Parse(vet[2]);


        int MAIORAB = (a + b + Math.Abs(a - b)) / 2;

        int MAIOR = (MAIORAB + c + Math.Abs(MAIORAB - c)) / 2;

        Console.WriteLine($"{MAIOR} eh o maior");

    }
}