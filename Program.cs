internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ile kostek chcesz rzucić?(3 - 10)");
        int wybrane = int.Parse(Console.ReadLine());
        int[] tablica = new int[wybrane];
        while (wybrane < 3 || wybrane > 10) 
        {
            Console.WriteLine("Ile kostek chcesz rzucić?(3 - 10)");
            wybrane = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("-----------------");
        Random random = new Random();
        int c = 0;
        int suma = 0;
        for (int i = 0; i < wybrane; i++) 
        {
            c++;
           int randomowa = random.Next(1, 7);
            tablica[i] = randomowa;
            Console.WriteLine($" Kostka {c}: {tablica[i]}");
            suma = suma + tablica[i];
        }
        Console.WriteLine($"Suma wyrzuconych oczek to: {suma}");


    }
}