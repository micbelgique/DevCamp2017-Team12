using System;
using System.Collections.Generic;
namespace UXDivers.Artina.Grial
{
	public class Personne
	{
		public string nom { get; set; }
		public string prenom { get; set; }
		public string numRegistreNationnal { get; set; }
		public string statut { get; set; }
		public string adresse { get; set; }
		public string dateNaissance { get; set; }
	
		public Personne()
		{
			nom = "Bonbeur";
			prenom = "Jean";
			numRegistreNationnal = "90012345678";
			statut = "Marié";
			adresse = "Avenue Léopole n°42, 1000 Bruxelles";
			dateNaissance = "16/09/1991";

		}

		public Personne(String nom, String prenom)
		{
			this.nom = nom;
			this.prenom = prenom;
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
