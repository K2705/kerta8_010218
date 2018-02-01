namespace Teht2
{
    /// <summary>
    /// The kind of food you find in a fridge
    /// </summary>
    public class Food
    {
        public string Name { get; set; }

        public Food(string name)
        {
            this.Name = name;
        }

        public Food() : this("leftovers")
        {
        }

        public virtual void Eat()
        {
            System.Console.WriteLine("You eat the " + Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// A bottle or paper carton of liquid
    /// </summary>
    public class Liquid : Food
    {
        public string Size { get; }

        public Liquid(string name, string size) : base (name)
        {
            this.Size = size;
        }

        public override void Eat()
        {
            System.Console.WriteLine("You drink the " + Name);
        }

        public override string ToString()
        {
            return Name + " (" + Size + ")";
        }
    }

    /// <summary>
    /// A box of eggs
    /// </summary>
    public class EggCarton : Food
    {
        public int MaxEggs { get; }
        public int CurrentEggs { get; private set; }
        private Egg[] Eggs;

        public EggCarton(int size) : base("egg carton")
        {
            MaxEggs = size;
            CurrentEggs = size;
            Eggs = new Egg[size];
            for (int i = 0; i < size; i++)
            {
                Eggs[i] = new Egg();
            }
        }

        public EggCarton() : this(12)
        {
        }

        public override void Eat()
        {
            if (CurrentEggs > 0)
            {
                System.Console.WriteLine("You eat an " + Eggs[CurrentEggs - 1] + " from " + Name);
                Eggs[CurrentEggs - 1] = null;
                CurrentEggs--;
            }
            System.Console.WriteLine("ERROR: Carton empty.");
        }

        public override string ToString()
        {
            return Name + " (" + CurrentEggs + " eggs)";
        }
    }

    /// <summary>
    /// An egg
    /// </summary>
    public class Egg : Food
    {
        public Egg() : base("egg")
        {
        }

        public Egg(string name) : base(name + " egg")
        {
        }
    }
}