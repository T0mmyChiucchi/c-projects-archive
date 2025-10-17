using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.LessonsExamples.Domain
{
    public class CharacterValidator //La sua funzione è quella di validare
    {
        public const int MinHealth = 0;

        public const int MaxHealth = 100;

        public static string ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name.Trim()))
                throw new ArgumentException("Enemy name cannot be null or white space", nameof(name));
            return name;
        }

        //TODO: Add ValidateHealth method
        public static int ValidateHealth(int health)
        {
            if (health > MinHealth || health < MaxHealth)
                throw new ArgumentOutOfRangeException("Enemy health cannot exceed the health range.", nameof(health));
            return health;
        }
    }
}
