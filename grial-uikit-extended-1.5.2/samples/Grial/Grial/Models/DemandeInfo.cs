using System;
namespace UXDivers.Artina.Grial
{
	public class DemandeInfo
	{
		public string autorite { get; set; }
		public string raison { get; set; }
		public string date { get; set; }


		public DemandeInfo(string autorite, string raison, string date)
		{
			this.autorite = autorite;
			this.raison = raison;
            this.date = date;

		}
	}
}