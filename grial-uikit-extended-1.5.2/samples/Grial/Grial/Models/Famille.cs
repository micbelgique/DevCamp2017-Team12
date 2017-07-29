using System.Collections.Generic;
namespace UXDivers.Artina.Grial
{
	public class Famille
	{

		public Personne conjoint;
		public Personne pere;
		public Personne mere;
		public List<Personne> enfants;

		public Famille()
		{
			enfants = new List<Personne>();
			enfants.Add(new Personne("Bonbeur","Jack"));
			conjoint = new Personne("Delune", "Claire");
			pere = new Personne("Bonbeur","Claude");
			mere = new Personne("Lutefinal","Sheila");
		}
	}
}
