using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Entity
{
	class ProduitDevis
	{
		[Key]
		public int id { get; set; }
		public int quantite { get; set; }
		public double prixUnitaire { get; set; }
		public double prixTotalHt { get; set; }
	}
}
