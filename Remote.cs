using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SmartDogDoors
{
    public class Remote
    {
        public DogDoor Door { get; set; }
        public Remote(DogDoor dogDoor)
        {
            Door = dogDoor;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (Door.IsOpen)
            {
                Door.Close();
                Console.WriteLine("The dog door closes.");
            }
            else
            {
                Door.Open();
                Console.WriteLine("The dog door opens.");
                Thread.Sleep(5000);
                Door.Close();                
            }
        }
    }
}