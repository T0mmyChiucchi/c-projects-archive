namespace BlaisePascal.LessonsExamples.Domain
{
    public class Enemy
    {
        //Attributes

        private int _health;
        private int _isAlive;
        private string _name;
        private string _description;



        //Properties

        /*public int Health
        {
            //get => _health
            get
            {
                return _health;
            }

            //set => _health = value
            set
            {
                if (_health < 0)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                _health = value;
            }
        } */

        public string Name { get; private set; }

        public string Description { get; private set; }

        public int Health { get; private set; }

        public bool IsAlive { get; private set; }



        //Constructors overload

        public Enemy() { } // Costruttore di default

        public Enemy(string name)
        {
            Name = name;
        }

        public Enemy(string name, int health)
        {
            Health = health;
            Name = name;
        }



        //Methods

        /// <summary>
        /// set a new name
        /// </summary>
        /// <param name="newName"></param>
        public void SetName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName.Trim()))
            {
                Name = newName;
            }

        }

        public void SetHealth(int newHealth)
        {
            if (int.IsPositive(newHealth) && newHealth > 100)
            {
                Health = newHealth;
            }
        }

        public void TakeDamage(int damage)
        {
            if (int.IsNegative(damage))
                throw new ArgumentOutOfRangeException("Damage cannot be negative");

            if (damage > 0 && damage < Health && IsAlive == true)
            {
                Health -= damage;
                //Health = Math.Min(0, Health - damage);
                IsAlive = true;
            }
            else
            {
                IsAlive = false;
                Health = 0;
            }
        }
    }
}