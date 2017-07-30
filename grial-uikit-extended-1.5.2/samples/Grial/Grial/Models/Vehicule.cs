using System;
namespace UXDivers.Artina.Grial
{
	public class Vehicule
	{
		public int vehiculeID { get; set; }
		public string numImmatriculation { get; set; }
		public DateTime datePremiereImmatriculation { get; set; }
		public string constructeur { get; set; }
		public int cylindree { get; set; }
		public int puissanceMaximale { get; set; }
		public string typeDeCarburant { get; set; }
		public DateTime annéeDeConstruction { get; set; }
		public Personne proprio { get; set; }


		Random rand;

		public Vehicule(Personne proprio)
		{
			rand = new Random();

			if (proprio == null) throw new ArgumentException("Le vehicule doit avoir un propriétaire");

			this.proprio = proprio;

			vehiculeID = rand.Next(100);
			numImmatriculation = getImmatriculation();
			//une date random entre 1900 et cette année
			datePremiereImmatriculation = new DateTime(rand.Next(1900, DateTime.Today.Year));
			constructeur = "Ford";
			cylindree = rand.Next(10, 80) / 10;
			puissanceMaximale = rand.Next(100, 1001);
			typeDeCarburant = "essance";
			annéeDeConstruction = datePremiereImmatriculation;

		}

		String getImmatriculation()
		{
			string immatriculation = "1";
			for (int i = 0; i < 3; i++)
			{
				char c = Convert.ToChar(rand.Next(65, 90));
				immatriculation += c;
			}
			for (int i = 0; i < 3; i++) immatriculation += rand.Next(0, 9);
			return immatriculation;
		}

		public Personne consulterProprio(DemandeInfo demande)
		{
			return proprio;
		}
	}
}
