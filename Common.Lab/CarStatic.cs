namespace Common.Lab
{
    using System;

    public class CarStatic
    {
        //Constantes
        public const int CapaciteReservoirEssence = 100;
        public const int CapaciteReservoirEssenceGlobal = 1000;

        //Constructeur statique
        static CarStatic()
        {
            ReservoirEssenceGlobal = CapaciteReservoirEssenceGlobal;
        }
        //Propriétés
        public int ReservoirEssence
        {
            get
            {
                return this.volumeEssence;
            }
            set
            {
                if (value >= 0 && value <= CapaciteReservoirEssence)
                {
                    this.volumeEssence = value;
                }
                else
                {
                    throw  new ArgumentOutOfRangeException("Volume d'essence invalide");
                }
            }
        }

        public int Kilometrage
        {
            get
            {
                return this.kilometrage;
            }
            private set
            {
                if (value >= 0)
                {
                    this.kilometrage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Kilometrage invalide");
                }
            }
        }

        //Propriété statique
        public static int ReservoirEssenceGlobal
        {
            get
            {
                return reservoirEssenceGlobal;
            }
            set
            {
                if (value >= 0)
                {
                    reservoirEssenceGlobal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Volume d'essence invalide");
                }
            }
        }

        //Méthodes
        public void ParcourirDistance(int kilometreParcouru)
        {
            if (kilometreParcouru > 0)
            {
                int essenceRequise = kilometreParcouru;

                if (this.ReservoirEssence >= essenceRequise)
                {
                    this.Kilometrage = (this.Kilometrage + kilometreParcouru);
                    this.ReservoirEssence = (this.ReservoirEssence - essenceRequise);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Volume essence insuffisant pour parcourrir distance");
                }
            }
        }

        public void FaireLePlein()
        {
            int essenceManquante = CapaciteReservoirEssence - this.ReservoirEssence;
            if (ReservoirEssenceGlobal >= essenceManquante)
            {
                ReservoirEssenceGlobal -= essenceManquante;
                this.ReservoirEssence += essenceManquante;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Volume d'essence dans le reservoir global insuffisant pour faire le plein");
            }
        }

        private int volumeEssence;
        private int kilometrage;
        private static int reservoirEssenceGlobal;
    }
}
