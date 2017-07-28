using System;
namespace UXDivers.Artina.Grial
{
	public class Personne
	{
		public string nom{ get; set; }
		public string prenom{ get; set; }
		public DateTime dateNaissance{ get; set; }
		public Vehicule[] vehicules { get; set; }
	}
}
