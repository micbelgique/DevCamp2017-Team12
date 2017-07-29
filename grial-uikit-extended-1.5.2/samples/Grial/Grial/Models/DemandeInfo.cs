using System;
namespace UXDivers.Artina.Grial
{
	public class DemandeInfo
	{
		public AutoritesPublique autorite { get; set; }
		public string raison { get; set; }

		public DemandeInfo(AutoritesPublique autorite, string raison)
		{
			this.autorite = autorite;
			this.raison = raison;
		}
	}
}