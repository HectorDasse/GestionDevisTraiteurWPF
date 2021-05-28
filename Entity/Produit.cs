using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Entity
{
	public class Produit
	{
		[Key]
		public int id { get; set; }
		public string nom { get; set; }
		public string unite { get; set; }
		public double prix { get; set; }
		public DateTime DateMiseAJour { get; set; }
		public Boolean ProduitSimple { get; set; }

		public Famille famille { get; set; }
	}
}
