using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine(hockeyClub.Name);
            Console.WriteLine(hockeyClub.City);
            for (int i = 0; i < hockeyClub.PlayerCount(); i++)
            {
                Console.WriteLine(hockeyClub.GetPlayer(i));
            }
        }
    }
}
