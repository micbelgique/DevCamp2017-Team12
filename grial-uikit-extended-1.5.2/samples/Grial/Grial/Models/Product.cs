using System;
using System.Collections.Generic;

namespace UXDivers.Artina.Grial
{
	public class Product
	{
        public List<DemandeInfo> Consultations { get; set; }



        public string Name {
			get;
			set;
		}

		public string Description {
			get;
			set;
		}

		public string Price {
			get;
			set;
		}

		public string Image {
			get;
			set;
		}

		public string Manufacturer {
			get{ return "UXDIVERS";}
			set{ }
		}

		public string ThumbnailHeight {
			get;
			set;
		}
        public Personne Personne { get; internal set; }

        public Product ()
		{
		}
	}
}

