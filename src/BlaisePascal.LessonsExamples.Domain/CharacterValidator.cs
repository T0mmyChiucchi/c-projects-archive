using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.LessonsExamples.Domain
{
    internal class CharacterValidator
    {
        private const int MinHealth = 0;

        private const int MaxHealth = 100;

        public static string ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name.Trim()))
                throw new ArgumentException("Enemy name cannot be null or white space");
            return name;
        }

        //TODO: Add ValidateHealth method
    }
}
