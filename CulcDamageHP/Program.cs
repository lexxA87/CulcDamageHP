namespace CulcDamageHP
{
    internal class Program
    {
        static Random random = new();

        static void Main(string[] args)
        {
            SwordDamage swordDamage = new(RollDice());
            ArrowDamage arrowDamage = new(RollDice());

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;

                swordDamage = new(RollDice());

                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                if (key == '0')
                {
                    swordDamage.Magic = false;
                    swordDamage.Flaming = false;
                }
                else if (key == '1')
                {
                    swordDamage.Magic = true;
                }
                else if (key == '2')
                {
                    swordDamage.Flaming = true;
                }
                else
                {
                    swordDamage.Magic = true;
                    swordDamage.Flaming = true;
                }

                Console.WriteLine("\nRolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP\n");
            }
        }

        static int RollDice(int numberOfRolls)
        {
            switch (numberOfRolls)
            {
                case 1:
                    return random.Next(1, 7);
                case 3:
                    return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                default:
                    return 0;
            }
        }
    }
}