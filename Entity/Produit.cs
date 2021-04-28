using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Devis_Traiteur.Entity
{
	class Produit
	{
		[Key]
		public int id { get; set; }
		public String nom { get; set; }
		public String unite { get; set; }
		public double prix { get; set; }


	}
}
