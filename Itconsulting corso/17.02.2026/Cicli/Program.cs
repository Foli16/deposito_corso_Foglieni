using System;

class Program
{
    static void Main()
    {
        // WHILE
        bool continua = true;

        while(continua)
        {
            Console.WriteLine("Ciclo in esecuzione");
            continua = bool.Parse(Console.ReadLine()!);
        }

        int continua2 = 0;
        while(continua2<10)
        {
            Console.WriteLine("Ciclo in esecuzione");
            continua2 +=1;
            Console.WriteLine(continua2);
        }

        // ESERCIZIO 1
        int n = 0;
        int somma = 0;
        while(n>=0)
        {
            somma += n;
            Console.WriteLine("Inserisci un numero intero positivo (o trova il modo di fuggire ihih):");
            n = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine($"Somma: {somma}");

        // ESERCIZIO 2
        const int segreto = 4;

        int input = 0;
        while(input != segreto)
        {
            Console.WriteLine("Indovina il numero segreto:");
            input = int.Parse(Console.ReadLine()!);
            if(input > segreto)
                Console.WriteLine("Troppo alto!");
            else if(input < segreto)
                Console.WriteLine("Troppo basso!");
            else
                Console.WriteLine("Indovinato!");
        }
    }
}
