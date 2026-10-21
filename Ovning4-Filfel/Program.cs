try
{
    // Försök läsa en fil som inte finns
    string text = File.ReadAllText("test.txt");

    Console.WriteLine(text);
}
catch (FileNotFoundException)
{
    Console.WriteLine("Fel: Filen kunde inte hittas!");
}
