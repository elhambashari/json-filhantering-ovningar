using System.Text.Json;

// Skapa en lista med namn
List<string> namnLista = new List<string>
{
    "Anna",
    "Erik",
    "Sara",
    "Johan",
    "Maria"
};

// Omvandla listan till JSON
string json = JsonSerializer.Serialize(
    namnLista,
    new JsonSerializerOptions { WriteIndented = true }
);

// Spara JSON i en fil
File.WriteAllText("namn.json", json);

Console.WriteLine("Namnlistan har sparats i namn.json!");
