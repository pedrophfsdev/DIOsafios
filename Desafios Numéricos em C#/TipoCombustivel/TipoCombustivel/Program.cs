using System;

class URI
{

    static void Main(string[] args)
    {

        int gasolina = 0;
        int alcool = 0;
        int diesel = 0;
        int i = 0;

        do
        {
            i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:
                    {
                        alcool++;
                        break;
                    }

                case 2:
                    {
                        gasolina++;
                        break;
                    }

                case 3:
                    {
                        diesel++;
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("MUITO OBRIGADO");
                    }

                    break;
                default:
                    continue;
            }
        }

        while (i != 4);
        {
            Console.WriteLine("Alcool: {0}", alcool);
            Console.WriteLine("Gasolina: {0}", gasolina);
            Console.WriteLine("Diesel: {0}", diesel);
        }

    }

}
