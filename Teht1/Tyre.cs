using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Tyre
    {
        public string Name;
        public string Type;
        public string Size;

        public Tyre(string name, string type, string size)
        {
            Name = name;
            Type = type;
            Size = size;
            
        }

        public Tyre(Tyre tyre)
        {
            Name = tyre.Name;
            Type = tyre.Type;
            Size = tyre.Size;
        }

        public override string ToString()
        {
            return Name + " " + Type + " " + Size;
        }
    }
}
