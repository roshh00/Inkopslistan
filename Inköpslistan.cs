List<string> names = new List<string>();
List<int> prices = new List<int>();

names.Add("Mjölk");
prices.Add(15);

names.Add("Bröd");
prices.Add(25);

names.Add("Ost");
prices.Add(60);

while (true)
{
    Console.WriteLine();
    PrintList(names, prices);
    Console.WriteLine();
    Console.Write("Skriv ett varunamn för att lägga till (tomt = avsluta): ");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        break;
    }

    input = input.Trim();

    // Fråga efter priset om det inte ett heltal läggs varan inte till.

    Console.Write("Pris: ");

    if (int.TryParse(Console.ReadLine(), out int price))
    {
        names.Add(input);
        prices.Add(price);
        Console.WriteLine("Varan lades till.");
    }
    else
    {
        Console.WriteLine("Priset måste vara ett heltal. Varan lades inte till.");
    }
}

// Skriver ut listan numrerad 1, 2, 3 följt av totalsumman.

void PrintList(List<string> itemNames, List<int> itemPrices)
{
    int total = 0;

    for (int i = 0; i < itemNames.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {itemNames[i]} - {itemPrices[i]} kr");
        total += itemPrices[i];
    }

    Console.WriteLine($"Totalt: {total} kr");
}