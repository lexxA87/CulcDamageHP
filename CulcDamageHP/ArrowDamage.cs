namespace CulcDamageHP
{
    internal class ArrowDamage : WeaponDamage
    {
        public ArrowDamage(int roll) : base(roll) { }


        private const decimal BASE_MULTYPLIER = 0.35M;
        private const decimal MAGIC_MULTYPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

        protected override void CalculateDamage()
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
