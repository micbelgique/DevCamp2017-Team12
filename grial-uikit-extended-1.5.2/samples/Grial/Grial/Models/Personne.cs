using System;
using System.Collections.Generic;
namespace UXDivers.Artina.Grial
{
	public class Personne
	{
		public string nom{ get; set; }
		public string prenom{ get; set; }
		public DateTime dateNaissance{ get; set; }
		public List<Vehicule> vehicules { get; set; }
		public Stack<DemandeInfo> demandes { get; set; }

		public Personne()
		{
			vehicules = new List<Vehicule>();
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
}
