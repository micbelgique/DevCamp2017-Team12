using System;
namespace UXDivers.Artina.Grial
{
	public class Data
	{
		public Data()
		{
			Personne moi = new Personne();
			Vehicule maVoiture = new Vehicule(moi);

			AutoritesPublique police = new AutoritesPublique();
			police.nom = "Police";

			maVoiture.consulterProprio(new DemandeInfo(police, "Le véhicule était sur deux roues"));

			//			var xx = moi.consulterVehicules(new DemandeInfo(police, "Le véhicule était sur deux roues"));

		}
	}
}
