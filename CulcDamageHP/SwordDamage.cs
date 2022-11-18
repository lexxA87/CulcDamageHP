namespace CulcDamageHP
{
    internal class SwordDamage : WeaponDamage
    {

        public SwordDamage(int roll) : base(roll) { }

        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;
            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }

    }
}
