namespace Common.Lab
{
    public class Revolver : AbstractGun
    {
        const int DEGATS_MINIMAUX = 5;
        const int FORCE_ARME = 15;

        public Revolver(int points)
            : base(points)
        {
        }

        public override int CalculeteDamage()
        {
            return DEGATS_MINIMAUX + FORCE_ARME * this.DamagePoints;
        }
    }
}