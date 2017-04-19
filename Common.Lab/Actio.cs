namespace Common.Lab
{
    public class Actio : AbstractSubject
    {
        const string Stable = "Le cours est inchangé";
        const string Hausse = "Le cours est en hausse";
        const string Baisse = "Le cours est à la baisse";

        public float Sommet { get; private set; }
        public float Bas { get; private set; }
        public float PrixCourant { get; private set; }
        public float Variation { get; private set; }
        public string EtatAction { get; private set; }

        public Actio(float coursActuel)
        {
            this.Sommet = this.Bas = this.PrixCourant = coursActuel;
            this.EtatAction = Stable;
        }
        public void AjouterObservateur(IObservable d)
        {
            this.Abonner(d);
        }

        public void RetirerObservateur(IObservable d)
        {
            this.Desabonner(d);
        }

        public void ModifierCours(float coursNouveau)
        {
            if (coursNouveau > this.PrixCourant) {
                this.EtatAction = Hausse; }
            else if (coursNouveau < this.PrixCourant) {
                this.EtatAction = Baisse; }
            else {
                this.EtatAction = Stable; }

            this.Variation = coursNouveau - this.PrixCourant;
            this.PrixCourant = coursNouveau;
            if (this.Sommet < this.PrixCourant) {
                this.Sommet = this.PrixCourant; }
            if (this.Bas > this.PrixCourant) {
                this.Bas = this.PrixCourant; }

            this.Notifier();
        }

        public override string ToString()
        {
            return this.Sommet + " -- " + this.Bas + " -- " +
                   this.PrixCourant + " -- " + this.Variation + " -- " + this.EtatAction;
        }
    }
}