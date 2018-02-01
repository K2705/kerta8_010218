using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    enum Handed : byte { Right, Left }
    enum Position : byte { Goalie, Defense, Offense }

    class HockeyPlayer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Position Position { get; set; }
        public Handed Handed { get; }

        public HockeyPlayer(string FirstName, string LastName, Position Position, Handed Handed)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
            this.Handed = Handed;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
