namespace Common.Lab
{
    public class Fighter
    {
        public string Name { get; internal set; }
        public AbstractGun Gun { get; internal set; }

        public Fighter(string name, AbstractGun gun)
        {
            this.Name = name;
            this.Gun = gun;
        }

        public int Attack()
        {
            return this.Gun.CalculeteDamage();
        }
    }
}