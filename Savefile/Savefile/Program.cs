using System;
using System.IO;

namespace Savefile
{
    //Code voor de highscores. De highscores die behaald worden, moeten naar een list (array?) geschreven worden die het spel weer uit kan lezen. Deze array moet opgeslagen worden in een bestand.
    class Program
    {

        static void Main(string[] args)
        {
            int Score = 234; //Score behaald in spel, komt dus geïntegreerd in het spel van de scorevariabele daar.
            string[] ScoreArray = new string[30];
            string[] InleesArray = new string[30]; //Voor het testen van tekstbestand inlezen naar array, een aparte array 

            ScoreArray[0] = "123";
            ScoreArray[1] = "456";
            ScoreArray[2] = "789";
            //Misschien checken of Mastersofmemory.sav al bestaat met een if-statement, anders wordt alles elke keer overschreven
            File.WriteAllLines(@"C:\Users\Public\MastersOfMemory.sav", ScoreArray);

            Console.WriteLine("Nu zijn er drie regels naar MastersOfMemory.sav geschreven.");
            Console.ReadKey();

            InleesArray = File.ReadAllLines(@"C:\Users\Public\MastersOfMemory.sav");

            //Door inhoud array loopen om te testen of het werkt
            foreach (string waarde in InleesArray)
            {
                Console.WriteLine(waarde);
            }

            Console.ReadKey();
        }
    }
}
