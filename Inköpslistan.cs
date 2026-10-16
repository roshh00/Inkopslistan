List<string> names = new List<string>();
List<int> prices = new List<int>();

names.Add("Mjölk");
prices.Add(15);
 
names.Add("Bröd");
prices.Add(25);
 
names.Add("Ost");
prices.Add(60);
 
PrintList(names, prices);
 
// Skriver ut listan numrerad 1, 2, 3  följt av totalsumman.

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
 