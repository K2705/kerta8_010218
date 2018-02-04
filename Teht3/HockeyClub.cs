using System;
using System.Collections.Generic;

namespace Teht3
{
    /// <summary>
    /// A hockey club, containing Players
    /// </summary>
    [Serializable()]
    class HockeyClub
    {
        /// <summary>
        /// Club name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Club home city
        /// </summary>
        public string City { get; }
        private List<HockeyPlayer> Players;

        public HockeyClub(string name, string city)
        {
            this.Name = name;
            this.City = city;
            this.Players = new List<HockeyPlayer>();
        }

        /// <summary>
        /// Get number of Players
        /// </summary>
        /// <returns>The number of Players, as integer</returns>
        public int PlayerCount()
        {
            return Players.Count;
        }

        /// <summary>
        /// Get the player at specific index
        /// </summary>
        /// <param name="i">Player index, starting from 0</param>
        /// <returns>the Player at i</returns>
        public HockeyPlayer GetPlayer(int i)
        {
            if (i >= Players.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return Players[i];
        }

        /// <summary>
        /// Add new player
        /// </summary>
        /// <param name="player">the Player to add</param>
        public void AddPlayer(HockeyPlayer player)
        {
            Players.Add(player);
        }

        /// <summary>
        /// Print object summary to console
        /// </summary>
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(City);
            for (int i = 0; i < PlayerCount(); i++)
            {
                Console.WriteLine(GetPlayer(i));
            }
        }
    }
}
