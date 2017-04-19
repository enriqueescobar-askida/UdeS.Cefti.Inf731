namespace Common.Lab
{
    public class MacroAction : Actio
    {
        public MacroAction(float coursActuel)
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