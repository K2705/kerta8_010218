using System;
using System.Collections.Generic;
using System.Text;

namespace Teht5
{
    class Baby : Human
    {
        public string Diaper { get; set; }

        public Baby()
        {
            Age = 0;
        }

        public override void Move()
        {
            Console.WriteLine("Crawling");
        }
    }
}
