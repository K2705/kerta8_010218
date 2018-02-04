using System;
using System.Collections.Generic;
using System.Text;

namespace Teht5
{
    class Human : Mammal
    {
        public override int Age { get; protected set; }

        public Human()
        {
            Age = 30;
        }

        public override void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Grow()
        {
            Age++;
        }
    }
}
