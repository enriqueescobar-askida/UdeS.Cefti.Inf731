namespace Common.Lab
{
    public class MiniAction : Actio
    {
        public MiniAction(float coursActuel)
            : base(coursActuel)
        {
        }

        public override string ToString()
        {
            string nomAction = this.GetType().ToString();

            return nomAction.Substring(nomAction.IndexOf('.') + 1) + " ---- " + base.ToString();
        }
    }
}