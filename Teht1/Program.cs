using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle porsche = new Vehicle("Porsche", "911", 4);
            porsche.AddAllTyres(new Tyre("Nokia", "Hakkapeliitta", "205R16"));
            porsche.PrintInfo();

            Vehicle ducati = new Vehicle("Ducati", "Diavel", 2);
            ducati.AddTyre(new Tyre("MIC", "Pilot", "160R17"));
            ducati.AddTyre(new Tyre("MIC", "Pilot", "160R16"));
            ducati.PrintInfo();
        }
    }
}
