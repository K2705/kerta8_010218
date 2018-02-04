using System;

namespace Teht3
{
    enum Handed : byte { Right, Left }
    enum Position : byte { Goalie, Defense, Offense }

    /// <summary>
    /// A hockey player
    /// </summary>
    [Serializable()]
    class HockeyPlayer
    {
        /// <summary>
        /// The Player's first name
        /// </summary>
        public string FirstName { get; }
        /// <summary>
        /// The Player's last name
        /// </summary>
        public string LastName { get; }
        /// <summary>
        /// the Player's position
        /// </summary>
        public Position Position { get; set; }
        /// <summary>
        /// whether the Player is left or right handed
        /// </summary>
        public Handed Handed { get; }

        public HockeyPlayer(string FirstName, string LastName, Position Position, Handed Handed)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
            this.Handed = Handed;
        }

        /// <summary>
        /// get the Player's name, formatted as Firstname Lastname
        /// </summary>
        /// <returns>Player's first and last name as string</returns>
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
