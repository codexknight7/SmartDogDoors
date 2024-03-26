using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDogDoors
{
    public class DogDoorSimulator
    {
        public static void Main()
        {
            DogDoor dogDoor = new DogDoor();
            dogDoor.AllowedBarks = new List<Bark>();
            dogDoor.AllowedBarks.Add(new Bark("rowlf"));
            dogDoor.AllowedBarks.Add(new Bark("rooowlf"));
            dogDoor.AllowedBarks.Add(new Bark("rawlf"));
            dogDoor.AllowedBarks.Add(new Bark("woof"));

            BarkRecognizer recognizer = new BarkRecognizer(dogDoor);
            Remote remote = new Remote(dogDoor); 

            Console.WriteLine("Fido barks to go outside...");
            recognizer.recognize(new Bark("rowlf"));
            //remote.PressButton();
            Console.WriteLine("\nFido has gone outside...");
            Thread.Sleep(10000);

            Console.WriteLine("\nFido's all done...");
            Console.WriteLine("\nFido's stuck outside...");

            // Simulate the hardware hearing a bark (not Bruce!)
            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking.");
            recognizer.recognize(smallDogBark);
            Thread.Sleep(5000);

            // Simulate the hardware hearing a bark again
            Console.WriteLine("nFido starts barking.");
            recognizer.recognize(new Bark("rooowlf"));
            Console.WriteLine("\nFido’s back inside...");
        }
    }
}
