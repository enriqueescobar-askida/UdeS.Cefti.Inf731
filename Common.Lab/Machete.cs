namespace Common.Lab
{
    public class Machete : AbstractGun
    {
        const int FORCE_ARME = 5;

        public Machete(int points)
            : base(points)
        {
        }

        public override int CalculeteDamage()
        {
            return FORCE_ARME * this.DamagePoints;
        }
    }
}