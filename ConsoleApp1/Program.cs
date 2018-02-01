using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Creature> creatures = new List<Creature>();
            creatures.Add(new Creature('@', 5, 5));
            creatures.Add(new Creature('c', 55, 15));
            creatures.Add(new Creature('f', 10, 10));

            while (true)
            {
                Console.Clear();
                PrintCreatures(creatures);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.LeftArrow:
                        creatures[0].X--;
                        break;
                    case ConsoleKey.RightArrow:
                        creatures[0].X++;
                        break;
                    case ConsoleKey.UpArrow:
                        creatures[0].Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        creatures[0].Y++;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void PrintCreatures(List<Creature> creatures)
        {
            foreach (Creature c in creatures)
            {
                Console.SetCursorPosition(c.X, c.Y);
                Console.Write(c.Glyph);
            }
        }
    }

    class Creature
    {
        public char Glyph { get; }
        private static int MinX = 1;
        private static int MaxX = 79;
        private static int MinY = 1;
        private static int MaxY = 23;
        private int X_;
        public int X
        {
            get
            {
                return X_;
            }
            set
            {
                if (value >= MinX && value <= MaxX) X_ = value;
            }
        }
        private int Y_;
        public int Y
        {
            get
            {
                return Y_;
            }
            set
            {
                if (value >= MinY && value <= MaxY) Y_ = value;
            }
        }
        public Creature() : this('X')
        {
        }
        public Creature(char c) : this(c, MinX, MinY)
        {
        }
        public Creature(char c, int x, int y)
        {
            Glyph = c;
            X = MinX;
            Y = MinY;
            X = x;
            Y = y;
        }

    }
}
