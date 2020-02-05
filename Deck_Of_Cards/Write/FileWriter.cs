using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static Deck_Of_Cards.WriteClass;

namespace Deck_Of_Cards
{
    public class FileWriter
    {
        public void WriterToFile(List<Player> listOfPlayers)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Deck_Of_Cards.txt")))
            {
                foreach (var player in listOfPlayers)
                {
                    outputFile.WriteLine(player.Name);
                    outputFile.WriteLine("---------------");
                    foreach (var card in player.Hand)
                    {
                        outputFile.WriteLine(card);
                    }
                    outputFile.WriteLine();
                }

            }
        }
    }
}
