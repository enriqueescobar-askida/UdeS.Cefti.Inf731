namespace Common.Lab
{
    public abstract class AbstractGun : IEvaluateDamage
    {
        int damagePoints;
        public int DamagePoints
        {
            get
            {
                return this.damagePoints;
            }
            private set
            {
                //if (value < 0) throw new IllegalGunException();
                this.damagePoints = value;
            }
        }

        public AbstractGun(int points)
        {
            this.DamagePoints = points;
        }

        public abstract int CalculeteDamage();
    }
}