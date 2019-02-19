namespace Animals.library
{
    public class Dog
    {

        public string Noise = "bark!";

        public void GoTo(string location)
        {
            System.Console.WriteLine("Walking to " + location);

            System.Console.WriteLine($"Walking to {location}");
        }

        public void MakeNoise()
        {
            System.Console.WriteLine(Noise);
        }
    }


}