using System;

namespace Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human alice = new Human();
            Console.WriteLine("Alice: " + alice.Age);
            alice.Grow();
            alice.Grow();
            alice.Grow();
            Console.WriteLine("Alice: " + alice.Age);

            Adult bob = new Adult();
            bob.Grow();
            bob.Car = "Lada";
            Console.WriteLine("Bob: " + bob.Age + ", " + bob.Car);

            Baby carol = new Baby();
            carol.Diaper = "Pampers";
            Console.WriteLine("Carol: " + carol.Age + ", " + carol.Diaper);

        }
    }
}
