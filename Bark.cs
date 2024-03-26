using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDogDoors
{
    public class Bark
    {
        public string Sound {  get; }

        public Bark(string sound)
        {
            Sound = sound;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Bark otherBark)
            {
                // Handle null case
                if (this.Sound == null && otherBark.Sound == null)
                    return true;
                if (this.Sound == null || otherBark.Sound == null)
                    return false;

                return string.Equals(this.Sound, otherBark.Sound, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
