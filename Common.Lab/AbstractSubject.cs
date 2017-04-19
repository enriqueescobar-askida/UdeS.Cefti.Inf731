namespace Common.Lab
{
    using System.Collections.Generic;

    public abstract class AbstractSubject
    {
        public List<IObservable> ObservableList { get; internal set; }

        public AbstractSubject()
        {
            this.ObservableList = new List<IObservable>();
        }
        public void Abonner(IObservable observateur)
        {
            this.ObservableList.Add(observateur);
        }

        public void Desabonner(IObservable observateur)
        {
            this.ObservableList.Remove(observateur);
        }

        public void Notifier()
        {
            foreach (IObservable o in this.ObservableList)
                o.MettreAJour();
        }
    }
}
