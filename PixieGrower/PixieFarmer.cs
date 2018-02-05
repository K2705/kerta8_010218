using System;
using System.Collections.Generic;

namespace PixieGrower
{
    /// <summary>
    /// A pixie farmer
    /// </summary>
    class PixieFarmer
    {
        public readonly int MAX_TERRARIUMS = 5;
        private Random random;
        private List<Terrarium> terrariums;
        public int Dust { get; private set; }

        public PixieFarmer()
        {
            random = new Random();
            terrariums = new List<Terrarium>();
            AddTerrarium();
            Dust = 0;
        }

        public int TerrariumCount()
        {
            return terrariums.Count;
        }

        /// <summary>
        /// Harvest from terrarium
        /// </summary>
        /// <param name="which">terrarium number</param>
        /// <returns>amount of dust harvested</returns>
        public int Harvest(int which)
        {
            if (which > terrariums.Count)
            {
                throw new ArgumentOutOfRangeException("There aren't that many terrariums!");
            }
            else
            {
                int harvested = terrariums[which].Harvest(random);
                Dust += harvested;
                return harvested;
            }
        }

        public bool TerrariumsNotFull()
        {
            return (terrariums.Count < MAX_TERRARIUMS);
        }

        /// <summary>
        /// Total pixie count
        /// </summary>
        /// <returns>number of all pixies in all terrariums, as integer</returns>
        public int CountAllPixies()
        {
            int count = 0;
            foreach (Terrarium t in terrariums)
            {
                count += t.PixieCount();
            }
            return count;
        }

        /// <summary>
        /// Pixies in specific terrarium
        /// </summary>
        /// <param name="i">which terrarium</param>
        /// <returns>number of pixies</returns>
        public int CountPixies(int i)
        {
            if (i > terrariums.Count) return 0;
            else return terrariums[i].PixieCount();
        }

        /// <summary>
        /// Remove some pixie dust
        /// </summary>
        /// <param name="dust">how much dust to remove</param>
        public void RemoveDust(int dust)
        {
            Dust -= dust;
        }

        /// <summary>
        /// Wait and let the pixies breed
        /// </summary>
        public void Wait()
        {
            foreach (Terrarium t in terrariums)
            {
                t.Wait();
            }
        }

        /// <summary>
        /// Add new terrarium with a breeding pair of pixies
        /// </summary>
        public void AddTerrarium()
        {
            if (TerrariumsNotFull())
            {
                int nextIndex = terrariums.Count;
                terrariums.Add(new Terrarium());
                terrariums[nextIndex].AddPixie(new Pixie());
                terrariums[nextIndex].AddPixie(new Pixie());
            }
        }

    }
}
