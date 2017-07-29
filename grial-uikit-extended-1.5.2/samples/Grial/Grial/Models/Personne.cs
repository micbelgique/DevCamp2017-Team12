using System;
using System.Collections.Generic;
namespace UXDivers.Artina.Grial
{
	public class Personne
	{
		public string nom{ get; set; }
		public string prenom{ get; set; }
		public string numRegistreNationnal{ get; set; }
		public Statut statut{ get; set; }
		public string adresse{ get; set; }
		public DateTime dateNaissance{ get; set; }
		public List<Vehicule> vehicules { get; set; }
		public Stack<DemandeInfo> demandes { get; set; }
		public Personne()
		{
			nom = "Omelcenco";
			prenom = "Denis";
			numRegistreNationnal = "90012345678";
			statut = Statut.Marié;
			adresse = "Avenue Léopole n°42, 1000 Bruxelles";
			dateNaissance = new DateTime(1990, 01, 23);
			vehicules = new List<Vehicule>();
			demandes = new Stack<DemandeInfo>();
		}


		public void consulter(DemandeInfo demande)
		{
			demandes.Push(demande);
		}
		public List<Vehicule> consulterVehicules(DemandeInfo demande)
		{
			demandes.Push(demande);
			return vehicules;
		}
	}
	public enum Statut
	{
		Célibataire,
		Marié,
		Divorcé,
		Veuf
	}
}
