using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDogDoors
{
    public class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void recognize(Bark bark)
        {
            Console.WriteLine("BarkRecognizer: Heard a '" + bark.Sound + "'");

            List<Bark> allowedBarks = door.AllowedBarks;
            foreach (Bark b in allowedBarks)
            {
                if (b.Sound.Equals(bark.Sound))
                {
                    door.Open();
                    return;
                }
            }
            Console.WriteLine("This dog is not allowed.");
        }
    }
}
