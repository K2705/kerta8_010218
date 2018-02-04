using System;
using System.Collections.Generic;
using System.Text;

namespace Teht5
{
    class Adult : Human
    {
        public string Car { get; set; }

        public Adult()
        {
            Age = 18;
        }

        public override void Move()
        {
            Console.WriteLine("Walking");
        }
    }
}
