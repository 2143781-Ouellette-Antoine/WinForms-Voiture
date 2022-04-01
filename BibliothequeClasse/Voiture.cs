namespace BibliothequeClasse
{
    public class Voiture : IEquatable<Voiture>, IComparable<Voiture>
    {
        private string nom;
        private string plaque;
        private uint poid;
        private uint odometre;
        private uint reservoir;
        private uint nombreKmDepuisDerniereRecharge;

        /// <summary>
        /// Nom de la voiture
        /// </summary>
        public string Nom
        {
            get { return nom; }
        }
        /// <summary>
        /// Plaque d'immatriculation
        /// </summary>
        public string Plaque
        {
            get { return plaque; }
        }
        /// <summary>
        /// Poid de la voiture ne peut être négatif
        /// valeurs en kg
        /// </summary>
        public uint Poid
        {
            get { return poid; }
            set { poid = value; }
        }
        /// <summary>
        /// Odomètre de la voiture ne peut être négatif
        /// valeurs en km
        /// </summary>
        public uint Odometre
        {
            get { return odometre; }
        }
        /// <summary>
        /// Réservoir de la voiture ne peut être négatif
        /// ou plus grand que 100 (representé un pourcentage)
        /// </summary>
        public uint Reservoir
        {
            get { return reservoir; }
        }
        /// <summary>
        /// Réservoir de la voiture ne peut être négatif
        /// ou plus grand que 100 (representé un pourcentage)
        /// </summary>
        public uint NombreKmDepuisDerniereRecharge
        {
            get { return nombreKmDepuisDerniereRecharge; }
        }

        /// <summary>
        /// Constructeur de la Voiture
        /// Le réservoir sera à 100%
        /// </summary>
        /// <param name="plaque">plaque d'immatriculation de la voiture</param>
        /// <param name="poid">poid de la voiture</param>
        public Voiture(string nom, string plaque, uint poid)
        {
            this.nom = nom;
            this.plaque = plaque;
            this.poid = poid;
            //Valeurs a la creation
            this.reservoir = 100;
            this.odometre = 0;
            this.nombreKmDepuisDerniereRecharge = 0;
        }

        /// <summary>
        /// Méthode pour faire le plein du réservoir
        /// et réinitialiser le nombre de Km depuis la dernière recharge
        /// <summary>
        public void Recharger()
        {
            this.reservoir = 100;//100%
            this.nombreKmDepuisDerniereRecharge = 0;//plus besoin de restants
        }

        /// <summary>
        /// Méthode pour ajuster les proprietés de la Voiture
        /// en fonction du nombre de km qu'elle a avancé
        /// </summary>
        /// <param name="nbrKm"></param>
        /// <returns>Pourcentage restant dans le réservoir</returns>
        public uint Avancer(uint nbrKm)//ex. 150km
        {
            //Ajouter le nbr de Km a ceux déjà en restant.
            this.nombreKmDepuisDerniereRecharge += nbrKm;//si c'est 0, là c'est rendu 150.

            //Verifier pas plus de 100% reservoir
            if (this.nombreKmDepuisDerniereRecharge > this.reservoir*100)
                this.nombreKmDepuisDerniereRecharge = this.reservoir*100;//Voyage toute l'essence.

            //Mettre à jour l'odomètre
            this.odometre += this.nombreKmDepuisDerniereRecharge;

            //Calcule le nombre de pourcentage entier
            uint pourcentageEnleve = this.nombreKmDepuisDerniereRecharge / 100;//int = pas décimales

            //Soustrait le pourcentageEnleve du Reservoir
            this.reservoir -= pourcentageEnleve;
            //Soustrait le pourcentageEnleve du restant sauvegardé
            this.nombreKmDepuisDerniereRecharge -= pourcentageEnleve * 100;//(1% = 100km)
            return pourcentageEnleve;
        }

        /// <summary>
        /// Méthode qui vérifie si deux Objects sont identiques.
        /// <param name="autre">l'autre objet que l'on veut comparer avec</param>
        /// <summary>
        public override bool Equals(Object? autre)
        {
            if (autre is null)
                return false;
            if (!(autre is Voiture))//false: si autre n'est pas une Voiture aussi.
                return false;
            Voiture voi = autre as Voiture;//Maintenant, on a deux objets Voiture.

            return Equals(voi);
        }

        /// <summary>
        /// Méthode qui vérifie si deux Voiture sont identiques.
        /// (Comparaison sur les plaques d'immatriculation)
        /// <param name="autre">l'autre Voiture que l'on veut comparer avec</param>
        /// <summary>
        public bool Equals(Voiture? autre)
        {
            if (autre is null)
                return false;

            return this.plaque == autre.plaque;
        }

        /// <summary>
        /// Méthode pour comparer deux objets Voiture
        /// (Comparaison sur les poids)
        /// <return>retourne la différence de poid entre
        ///     la première et la deuxième voiture</return>
        /// <summary>
        public int CompareTo(Voiture? other)
        {
            //Si c'est null, retourne 1.
            if (other is null)
                return 1;
            else
                return (int)(this.poid - other.poid);//retourne la différence (positive ou négative).
        }

    }
}