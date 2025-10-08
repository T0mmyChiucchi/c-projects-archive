namespace BlaisePascal.LessonsExamples.Domain
{
    public class Enemy
    {
        private int _health;
        private int _isAlive;
        private string _name;
        private string _description;
        private int _positionX;
        private int _positionY;
        private int _attackDamage;
        private int _attackSpeed;
        private int _attackMode;
        private int _damageReduction;
        private string _equipment;
        private int _movementSpeed;

        // Overload dei costruttori

        public Enemy() { } // Costruttore di default
        public Enemy(string name)
        {
            SetName(name);
        }

        public Enemy(string name, int health)
        {
            SetHealth(health);
            SetName(name);
        }


        /// <summary>
        /// set a new name
        /// </summary>
        /// <param name="newName"></param>
        public void SetName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
            {
                _name = newName;
            }

        }

        public void SetHealth(int newHealth)
        {
            if (int.IsPositive(newHealth) && newHealth > 100)
            {
                _health = newHealth;
            }
        }


        public string GetName() => _name;


        public int GetHealth() => _health;
    }
}
