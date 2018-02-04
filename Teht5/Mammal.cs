using System;
using System.Collections.Generic;
using System.Text;

namespace Teht5
{
    abstract class Mammal
    {
        public abstract int Age { get; protected set; }

        public abstract void Move();
        
    }
}
