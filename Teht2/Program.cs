namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge fridge = new Fridge();
            fridge.Contents.Add(new Liquid("milk", "1 l"));
            fridge.Contents.Add(new Liquid("orange juice", "1 l"));
            fridge.Contents.Add(new Liquid("cream", "2 dl"));
            fridge.Contents.Add(new EggCarton());
            fridge.Contents.Add(new Food());

            fridge.WriteContents();
        }
    }
}
