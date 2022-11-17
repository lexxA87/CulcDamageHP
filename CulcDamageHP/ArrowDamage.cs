namespace CulcDamageHP
{
    internal class ArrowDamage
    {
        public ArrowDamage(int roll)
        {
            Roll = roll;
            Magic = false;
            Flaming = false;
            CalculateDamage();
        }

        private const decimal BASE_MULTYPLIER = 0.35M;
        private const decimal MAGIC_MULTYPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        /// <summary>
        /// int Damage is calculated sum all damages
        /// </summary>
        public int Damage { get; private set; }

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
        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTYPLIER;
            if (Magic)
            {
                baseDamage *= MAGIC_MULTYPLIER;
            }
            if (Flaming)
            {
                Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            }
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
