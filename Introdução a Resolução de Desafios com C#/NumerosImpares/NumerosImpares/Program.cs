using System;

class minhaClasse
{

    public static void Main()
    {
        int n;
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }

}
