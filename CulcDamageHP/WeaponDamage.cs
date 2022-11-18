namespace CulcDamageHP
{
    internal class WeaponDamage
    {
        public WeaponDamage(int roll)
        {
            Roll = roll;
            Magic = false;
            Flaming = false;
            CalculateDamage();
        }

        public int Damage { get; protected set; }

        private int roll;
        /// <summary>
        /// int Roll is sum three dice
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        /// <summary>
        /// bool Flaming for calculate flaming damage
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        private bool magic;
        /// <summary>
        /// bool Magic for calculate magic damage
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        protected virtual void CalculateDamage()
        {
            // overrides in subclasses
        }
    }
}
