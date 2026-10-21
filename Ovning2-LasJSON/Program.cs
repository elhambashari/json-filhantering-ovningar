using System.Text.Json;

// Sökvägen till JSON-filen från övning 1
string filnamn = Path.Combine(
    "..",
    "Ovning1-SkrivJSON",
    "user.json"
);

// Läs JSON-filen
string json = File.ReadAllText(filnamn);

// Omvandla JSON till ett User-objekt
User? user = JsonSerializer.Deserialize<User>(json);

// Visa informationen
if (user != null)
{
    Console.WriteLine($"Namn: {user.Namn}");
    Console.WriteLine($"Ålder: {user.Alder}");
}
else
{
    Console.WriteLine("Ingen användare hittades.");
}

public class User
{
    public string Namn { get; set; } = "";
    public int Alder { get; set; }
}
