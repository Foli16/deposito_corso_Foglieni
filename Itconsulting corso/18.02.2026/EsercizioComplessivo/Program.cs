using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Registrazione--");
        Console.Write("Nome utente: ");
        string usernameR = Console.ReadLine()!;
        Console.Write("Password: ");
        string passwordR = Console.ReadLine()!;

        Console.WriteLine("--Login--");
        string answer;
        do
        {
            Console.Write("Nome utente: ");
            string usernameL = Console.ReadLine()!;
            Console.Write("Password: ");
            string passwordL = Console.ReadLine()!;

            if(usernameL == usernameR && passwordL == passwordR)
            {
                Console.WriteLine("Login effettuato!");
                Console.WriteLine("Vuoi far partire il nostro fantastico conto alla rovescia? (y/n)");
                string reply = Console.ReadLine()!;
                if(reply == "y")
                    Console.WriteLine("Quanto deve essere lungo? Dammi un numero intero");
                    

                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine($"Conto alla rovescia: {i}");
                }
            }

            Console.WriteLine("Vuoi riprovare? (y/n)");
            answer = Console.ReadLine()!;
        }while(answer == "y");
    }
}