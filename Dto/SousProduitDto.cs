using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Dto
{
	class SousProduitDto
	{

		public string nom { get; set; }
		public double prix { get; set; }
		public DateTime DateMiseAJour { get; set; }

		ProduitDto ProduitDto { get; set; }
	}
}
