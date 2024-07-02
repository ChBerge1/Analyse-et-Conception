using System;

namespace ApplicationDemandeDeFormation
{
    public class DemandeDeFormation
    {
        // Attributs privés
        private int demandeId;
        private DateTime dateDemandee;
        private string coursFournisseur;
        private string coursCode;
        private string coursTitre;
        private DateTime dateLimiteInscription;
        private int dureePendantTravail;
        private int dureeApresTravail;
        private decimal fraisCours;
        private decimal fraisVoyage;
        private DateTime coursDateDebut;
        private DateTime coursDateFin;

        // Constructeur
        public DemandeDeFormation(int demandeId, DateTime dateDemandee, string coursFournisseur, string coursCode, string coursTitre,
                                  DateTime dateLimiteInscription, int dureePendantTravail, int dureeApresTravail,
                                  decimal fraisCours, decimal fraisVoyage, DateTime coursDateDebut, DateTime coursDateFin)
        {
            this.demandeId = demandeId;
            this.dateDemandee = dateDemandee;
            this.coursFournisseur = coursFournisseur;
            this.coursCode = coursCode;
            this.coursTitre = coursTitre;
            this.dateLimiteInscription = dateLimiteInscription;
            this.dureePendantTravail = dureePendantTravail;
            this.dureeApresTravail = dureeApresTravail;
            this.fraisCours = fraisCours;
            this.fraisVoyage = fraisVoyage;
            this.coursDateDebut = coursDateDebut;
            this.coursDateFin = coursDateFin;
        }

        // Propriétés publiques (getters et setters)
        public int DemandeId
        {
            get { return demandeId; }
            set { demandeId = value; }
        }

        public DateTime DateDemandee
        {
            get { return dateDemandee; }
            set { dateDemandee = value; }
        }

        public string CoursFournisseur
        {
            get { return coursFournisseur; }
            set { coursFournisseur = value; }
        }

        public string CoursCode
        {
            get { return coursCode; }
            set { coursCode = value; }
        }

        public string CoursTitre
        {
            get { return coursTitre; }
            set { coursTitre = value; }
        }

        public DateTime DateLimiteInscription
        {
            get { return dateLimiteInscription; }
            set { dateLimiteInscription = value; }
        }

        public int DureePendantTravail
        {
            get { return dureePendantTravail; }
            set { dureePendantTravail = value; }
        }

        public int DureeApresTravail
        {
            get { return dureeApresTravail; }
            set { dureeApresTravail = value; }
        }

        public decimal FraisCours
        {
            get { return fraisCours; }
            set { fraisCours = value; }
        }

        public decimal FraisVoyage
        {
            get { return fraisVoyage; }
            set { fraisVoyage = value; }
        }

        public DateTime CoursDateDebut
        {
            get { return coursDateDebut; }
            set { coursDateDebut = value; }
        }

        public DateTime CoursDateFin
        {
            get { return coursDateFin; }
            set { coursDateFin = value; }
        }

        // Méthode pour afficher les détails de la demande
        public void AfficherDetails()
        {
            Console.WriteLine("Demande ID: " + demandeId);
            Console.WriteLine("Date Demandée: " + dateDemandee);
            Console.WriteLine("Cours Fournisseur: " + coursFournisseur);
            Console.WriteLine("Cours Code: " + coursCode);
            Console.WriteLine("Cours Titre: " + coursTitre);
            Console.WriteLine("Date Limite Inscription: " + dateLimiteInscription);
            Console.WriteLine("Durée Pendant Travail: " + dureePendantTravail);
            Console.WriteLine("Durée Après Travail: " + dureeApresTravail);
            Console.WriteLine("Frais Cours: " + fraisCours);
            Console.WriteLine("Frais Voyage: " + fraisVoyage);
            Console.WriteLine("Cours Date Début: " + coursDateDebut);
            Console.WriteLine("Cours Date Fin: " + coursDateFin);
        }
    }
}
