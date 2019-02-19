namespace Animals.UI
{
    public class Dog
    {

        internal string Noise = "bark!";

        internal void GoTo(string location)
        {
            System.Console.WriteLine("Walking to " + location);

            System.Console.WriteLine($"Walking to {location}");
        }

        internal void MakeNoise()
        {
            System.Console.WriteLine(Noise);
        }
    }


}