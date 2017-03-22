namespace Week9.Demo
{
    using System;
    using System.Linq;
    using System.Threading;

    using Common.Lab;

    class Program
    {
        static void Main(string[] args)
        {
            JournalLog journal = new JournalLog();
            journal.Publish("Démarrage du programme");
            journal.Publish("Première entrée");
            // Méthode spéciale pour suspendre le programe 1.3 sec
            Thread.Sleep(1300);
            journal.Publish("Deuxième entrée");
            // Méthode spéciale pour suspendre le programe 2.4 sec
            Thread.Sleep(2400);
            journal.Publish("Troisième entrée");
            // Méthode spéciale pour suspendre le programe 1/3 sec
            Thread.Sleep(300);
            journal.Publish("Quatrième entrée");
            journal.Publish("Fin programme");

            AfficherLog(journal);
            Console.In.ReadLine();
        }

        static void AfficherLog(JournalLog journal)
        {
            for (int i = 0; i < journal.EntryLogList.Count; ++i)
                Console.WriteLine(journal.EntryLogList.ElementAt(i));
        }
    }
}
