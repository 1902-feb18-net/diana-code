using System;

namespace Animals.library
{
    public class Dog
    {

        public string Noise = "bark";

        public string _name {get; set;}

        //use properties(these) instead of getters and setters (best prazctice in C#)
        private string Name
        {
            get{
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Color { get; } = "brow;";

        public int Id {get; set;} = 0;

        public void GoTo(string location)
        {
            Console.WriteLine("Walking to " + location);

            Console.WriteLine($"Walking to {location}");
        }

        public void MakeNoise()
        {
            Console.WriteLine($"{Noise}!");
        }

        //setter
        public void setNoise(string newValue)
        {
            if(newValue.Length == null|| newValue.Length == 0)
            {
                throw new ArgumentException("Value must not be null or empty");

            }
            Noise = newValue;
        }
    }


}