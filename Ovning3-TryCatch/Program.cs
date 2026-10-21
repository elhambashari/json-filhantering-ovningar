try
{
    Console.Write("Skriv ett nummer: ");

    int nummer = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Du skrev numret: {nummer}");
}
catch (FormatException)
{
    Console.WriteLine("Fel: Du måste skriva ett nummer!");
}
catch (OverflowException)
{
    Console.WriteLine("Fel: Numret är för stort eller för litet!");
}
