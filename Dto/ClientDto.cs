using GestionDevisTraiteurWPF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Dto
{
	public class ClientDto : EntityDto
	{

		public string nom { get; set; }
		public string prenom { get; set; }
		public string adresse { get; set; }
	}
}
