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
            Remote remote = new Remote(dogDoor); 

            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();
            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido's all done...");

            Thread.Sleep(10000);
            Console.WriteLine("\nFido's stuck outside...");
            Console.WriteLine("\nFido starts barking...");
            Console.WriteLine("\nGina grabs the remote control.");

            remote.PressButton();
            Console.WriteLine("\nFido's back inside...");
            Console.WriteLine("\nThe dog door closes.");
        }
    }
}
