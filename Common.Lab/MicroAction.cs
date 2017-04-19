namespace Common.Lab
{
    public class MicroAction : Actio
    {
        public MicroAction(float coursActuel)
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