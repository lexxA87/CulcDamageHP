namespace CulcDamageHP
{
    public class SwordDamage
    {

        public SwordDamage(int roll)
        {
            Roll = roll;
            Magic = false;
            Flaming = false;
            CalculateDamage();
        }

        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

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
            if (Magic && Flaming)
            {
                Damage = (int)(Roll * 1.75) + BASE_DAMAGE + FLAME_DAMAGE;
            }
            else if (Magic)
            {
                Damage = (int)(Roll * 1.75) + BASE_DAMAGE;
            }
            else if (Flaming)
            {
                Damage = (int)(Roll * 1) + BASE_DAMAGE + FLAME_DAMAGE;
            }
            else
            {
                Damage = (int)(Roll * 1) + BASE_DAMAGE;
            }
        }

    }
}
