namespace PixieGrower
{
    /// <summary>
    /// A pixie, bred for its magical dust
    /// </summary>
    class Pixie
    {
        private readonly int AGE_MAX = 10;
        public int Dust { get; private set; }
        private int age;

        public Pixie()
        {
            Dust = 0;
            age = 0;
        }

        /// <summary>
        /// Age pixie by one
        /// </summary>
        /// <returns>true if pixie died of old age, false if not</returns>
        public bool Wait()
        {
            age++;
            Dust += age;
            if (age > AGE_MAX)
            {
                return true;
            }
            else return false;
        }
    }
}
