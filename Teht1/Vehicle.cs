using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Vehicle
    {
        public string Name;
        public string Model;
        private Tyre[] Tyres;

        public Vehicle(string name, string model, int tyreCount)
        {
            Name = name;
            Model = model;
            Tyres = new Tyre[tyreCount];
            Console.WriteLine("Created new vehicle " + Name + " model " + Model);
        }

        public void AddAllTyres(Tyre tyre)
        {
            for (int i = 0; i < Tyres.Length; i++)
            {
                Tyres[i] = new Tyre(tyre);
                Console.WriteLine("Tyre " + tyre.Name + " added to vehicle " + Name);
            }
        }

        public void AddTyre(Tyre tyre)
        {
            int where = -1;
            for (int i = 0; i < Tyres.Length; i++)
            {
                if (Tyres[i] == null)
                {
                    where = i;
                }
            }
            if (where == -1)
            {
                Console.WriteLine("Could not add tyre " + tyre + ": All slots taken");
                
            }
            else
            {
                Tyres[where] = new Tyre(tyre);
                Console.WriteLine("Tyre " + tyre.Name + " added to vehicle " + Name);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Vehicle " + Name + " " + Model);
            Console.WriteLine("Tyres:");
            for (int i = 0; i < Tyres.Length; i++)
            {
                Console.WriteLine(Tyres[i]);
            }
        }
    }
}
