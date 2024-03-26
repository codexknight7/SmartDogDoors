using System;
using System.Collections.Generic;
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
            BarkRecognizer recognizer = new BarkRecognizer(dogDoor);
            Remote remote = new Remote(dogDoor); 

            Console.WriteLine("Fido barks to go outside...");
            recognizer.recognize("Woof");
            //remote.PressButton();
            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido's all done...");
            recognizer.recognize("Woof");
            Thread.Sleep(10000);
            Console.WriteLine("\nFido's stuck outside...");
            Console.WriteLine("\nFido starts barking...");
            recognizer.recognize("Woof");

            //Console.WriteLine("\nGina grabs the remote control.");
            //remote.PressButton();
            Console.WriteLine("\nFido's back inside...");
        }
    }
}
