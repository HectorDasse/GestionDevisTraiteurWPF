using GestionDevisTraiteurWPF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Dto
{
	class SousProduitDto : EntityDto
	{

		public string nom { get; set; }
		public double prix { get; set; }
		public DateTime DateMiseAJour { get; set; }
		public int quantite { get; set; }
		public double poids { get; set; }

		public ProduitDto ProduitDto { get; set; }
	}
}
