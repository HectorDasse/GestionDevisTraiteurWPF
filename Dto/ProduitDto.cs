using GestionDevisTraiteurWPF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Dto
{
	public class ProduitDto : EntityDto
	{

		public string nom { get; set; }
		public string unite { get; set; }
		public double prix { get; set; }
		
		public FamilleDto famille { get; set; }
	}
}
