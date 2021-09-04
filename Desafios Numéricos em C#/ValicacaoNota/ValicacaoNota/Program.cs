using System;

class minhaClasse
{

    static void Main(string[] args)
    {

        double SomaNotas = 0;
        int contador = 0;


        do
        {
            double notaEntrada = double.Parse(Console.ReadLine());

            if (notaEntrada < 0 || notaEntrada > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                contador++;
                SomaNotas += notaEntrada;
            }
        }
        while (contador < 2);
        {

            Console.WriteLine("media = " + (SomaNotas / 2).ToString("N2"));
        }





    }

}