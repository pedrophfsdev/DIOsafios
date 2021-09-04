using System;

class TempoDoDobby
{

    public static void Main()
    {
        var N = int.Parse(Console.ReadLine());
        string[] line = Console.ReadLine().Split();
        var A = int.Parse(line[0]);
        var B = int.Parse(line[1]);

        if (N < (A + B))
        {
            Console.Write("Deixa para amanha!");

        }
        else
        {
            Console.Write("Farei hoje!");
        }
    }
}
