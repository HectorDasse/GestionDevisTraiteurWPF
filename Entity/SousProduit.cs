using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Entity
{
	public class SousProduit
	{
		[Key]
		public int id { get; set; }
		public string nom { get; set; }
		public double prix { get; set; }
		public DateTime DateMiseAJour { get; set; }
		public int quantite { get; set; }
		public double poids { get; set; }

		public Produit produit { get; set; }
	}
}
