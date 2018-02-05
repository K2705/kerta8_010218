using System;
using System.Collections.Generic;

namespace PixieGrower
{
    /// <summary>
    /// A pixie terrarium
    /// </summary>
    class Terrarium
    {
        private readonly int MAX_PIXIES = 10;
        private List<Pixie> pixies;

        public Terrarium()
        {
            pixies = new List<Pixie>();
        }

        /// <summary>
        /// Age all pixies, birth new pixies if applicable
        /// </summary>
        public void Wait()
        {
            if (pixies.Count >= 2)
            {
                AddPixie(new Pixie());
            }

            for (int i = 0; i < pixies.Count; i++)
            {
                if (pixies[i].Wait())       //age pixie
                {
                    pixies.RemoveAt(i);     //if it died, get rid of it
                }
            }
        }

        /// <summary>
        /// Harvest a pixie for dust.
        /// This kills the pixie
        /// </summary>
        /// <param name="random">Random number generator to use for picking a pixie</param>
        /// <returns>Amount of dust harvested</returns>
        public int Harvest(Random random)
        {
            if (pixies.Count == 0) return 0;

            int pixieIndex = random.Next(0, pixies.Count);
            int dust = pixies[pixieIndex].Dust;
            pixies.RemoveAt(pixieIndex);
            return dust;
        }

        /// <summary>
        /// Add new pixie
        /// Silently fails if terrarium is full
        /// </summary>
        /// <param name="pixie">The Pixie to be added</param>
        public void AddPixie(Pixie pixie)
        {
            if (pixies.Count < MAX_PIXIES)
            {
                pixies.Add(pixie);
            }
        }

        /// <summary>
        /// Count pixies
        /// </summary>
        /// <returns>number of pixies in terrarium, as integer</returns>
        public int PixieCount()
        {
            return pixies.Count;
        }
    }
}
