using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Entity
{
	class Devis
	{
		[Key]
		public int id { get; set; }
		public string nom { get; set; }
		public double prixHtSansMarge { get; set; }
		public double prixHtAvecMarge { get; set; }
		public double coefficientMarge { get; set; }
		public int nombrePersonne { get; set; }
		public int nombreCuisinier { get; set; }
		public int nombreServeur { get; set; }
		public DateTime tempsTravail { get; set; }

		public List<ProduitDevis> ProduitDevis { get; set; }
	}
}
