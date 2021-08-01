using GestionDevisTraiteurWPF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Dto
{
	class DevisDto : EntityDto
	{

		public string nom { get; set; }
		public double prixHtSansMarge { get; set; }
		public double prixHtAvecMarge { get; set; }
		public double coefficientMarge { get; set; }
		public int nombrePersonne { get; set; }
		public int nombreCuisinier { get; set; }
		public int nombreServeur { get; set; }
		public DateTime tempsTravail { get; set; }

	}
}
