using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class HockeyClub
    {
        public string Name { get; }
        public string City { get; }
        private List<HockeyPlayer> Players;

        public HockeyClub(string name, string city)
        {
            this.Name = name;
            this.City = city;
            this.Players = new List<HockeyPlayer>();
        }

        public int PlayerCount()
        {
            return Players.Count;
        }

        public HockeyPlayer GetPlayer(int i)
        {
            if (i >= Players.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return Players[i];
        }

        public void AddPlayer(HockeyPlayer player)
        {
            Players.Add(player);
        }
    }
}
