using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            HockeyClub hockeyClub = new HockeyClub("testclub", "no city");
            hockeyClub.AddPlayer(new HockeyPlayer("Player1", "NoLastName", Position.Goalie, Handed.Left));
            hockeyClub.AddPlayer(new HockeyPlayer("Player2", "NoLastName", Position.Defense, Handed.Right));
            hockeyClub.AddPlayer(new HockeyPlayer("Player3", "NoLastName", Position.Defense, Handed.Right));
            hockeyClub.AddPlayer(new HockeyPlayer("Player4", "NoLastName", Position.Offense, Handed.Right));
            hockeyClub.AddPlayer(new HockeyPlayer("Player5", "NoLastName", Position.Offense, Handed.Left));
            hockeyClub.AddPlayer(new HockeyPlayer("Player6", "NoLastName", Position.Offense, Handed.Right));
            hockeyClub.AddPlayer(new HockeyPlayer("Player7", "NoLastName", Position.Defense, Handed.Right));

            hockeyClub.Print();

            //Save into a file
            Stream stream = File.Open("data.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, hockeyClub);
            stream.Close();

            //Wipe the hockeyClub
            hockeyClub = null;

            //Load from file
            stream = File.Open("data.dat", FileMode.Open);
            formatter = new BinaryFormatter();
            hockeyClub = (HockeyClub)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine();
            Console.WriteLine("Test file saving...");

            hockeyClub.Print();
        }

        private static void Print(HockeyClub hockeyClub)
        {
            
        }
    }
}
