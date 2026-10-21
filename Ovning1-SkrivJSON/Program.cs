using System.Text.Json;

// Fråga användaren om namn
Console.Write("Ange ditt namn: ");
string namn = Console.ReadLine() ?? "";

// Fråga användaren om ålder
Console.Write("Ange din ålder: ");
int alder;

if (!int.TryParse(Console.ReadLine(), out alder))
{
    Console.WriteLine("Fel: Du måste skriva ett nummer!");
    return;
}

// Skapa ett objekt med användarens information
User user = new User
{
    Namn = namn,
    Alder = alder
};

// Omvandla objektet till JSON
string json = JsonSerializer.Serialize(
    user,
    new JsonSerializerOptions { WriteIndented = true }
);

// Spara JSON i en fil
File.WriteAllText("user.json", json);

Console.WriteLine("Informationen har sparats i user.json!");

public class User
{
    public string Namn { get; set; } = "";
    public int Alder { get; set; }
}
