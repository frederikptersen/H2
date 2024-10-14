using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Step 1: Indlæs data fra filen
        string[] words = File.ReadAllLines("words.txt");

        // Validering: Sørg for, at hvert ord er 5 bogstaver langt
        foreach (var word in words)
        {
            if (word.Length != 5)
            {
                Console.WriteLine($"Fejl: {word} opfylder ikke kravene (ikke 5 bogstaver langt).");
            }
            else
            {
                Console.WriteLine(word);  // Udskriv ordene for at sikre korrekt indlæsning
            }
        }
    }
}
