using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            double A, B, C;

            Console.Clear();

            Console.WriteLine("Voer de lengte in cijfers van de drie zijden van de rechthoekige driehoek in:");
            Console.Write("De overstaande zijde A: ");
            string numA = Console.ReadLine();
            if (!double.TryParse(numA, out A))
            {
                Console.WriteLine("Ongeldige invoer voor zijde A. Voer een cijfer in.");
                Console.WriteLine("\nDruk op Enter om opnieuw te spelen of typ 'stop' om te stoppen.");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "stop")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.ReadLine();
                    continue;
                }
                
            }

            Console.Write("De aanliggende zijde B: ");
            string numB = Console.ReadLine();
            if (!double.TryParse(numB, out B))
            {
                Console.WriteLine("Ongeldige invoer voor zijde B. Voer een cijfer in.");
                Console.WriteLine("\nDruk op Enter om opnieuw te spelen of typ 'stop' om te stoppen.");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "stop")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.ReadLine();
                    continue;
                }
            }

            Console.Write("De schuine zijde C: ");
            string numC = Console.ReadLine();
            if (!double.TryParse(numC, out C))
            {
                Console.WriteLine("Ongeldige invoer voor zijde C. Voer een cijfer in.");
                Console.WriteLine("\nDruk op Enter om opnieuw te spelen of typ 'stop' om te stoppen.");
                string input2 = Console.ReadLine();
                if (input2.ToLower() == "stop")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.ReadLine();
                    continue;
                }
            }

            if (RechthoekigeDriehoek(A, B, C))
            {
                // Bereken de hoeken
                double hoekA = Math.Asin(A / C) * 180 / Math.PI;
                double hoekB = Math.Asin(B / C) * 180 / Math.PI;
                double hoekC = 90;

                // Bereken de sinus, cosinus en tangens van hoek α
                double sinusA = Math.Sin(hoekA * Math.PI / 180);
                double cosinusA = Math.Cos(hoekA * Math.PI / 180);
                double tangensA = Math.Tan(hoekA * Math.PI / 180);

                // Geef de resultaten weer
                Console.WriteLine("\nDit is een rechthoekige driehoek.");
                Console.WriteLine($"Hoek A: {hoekA}°");
                Console.WriteLine($"Hoek B: {hoekB}°");
                Console.WriteLine($"Hoek C: {hoekC}°");
                Console.WriteLine($"Cosinus van hoek α: {cosinusA}");
                Console.WriteLine($"Tangens van hoek α: {tangensA}");
                Console.WriteLine($"Sinus van hoek α: {sinusA}");
                Console.WriteLine($"Cosinus van hoek α: {cosinusA}");
                Console.WriteLine($"Tangens van hoek α: {tangensA}");
            }
            else
            {
                Console.WriteLine("\nDit is geen rechthoekige driehoek. Probeer opnieuw.");
            }

            Console.WriteLine("\nDruk op Enter om opnieuw te spelen of typ 'stop' om te stoppen.");
            string input = Console.ReadLine();
            if (input.ToLower() == "stop")
                break;
        }
    }

    // Functie om te controleren of het een rechthoekige driehoek is
    static bool RechthoekigeDriehoek(double A, double B, double C)
    {
        double Product = A * A + B * B;
        double Kwadraat = C * C;
        return Product == Kwadraat;
    }
}
