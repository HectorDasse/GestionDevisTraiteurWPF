using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Entity
{
	class Client
	{
		[Key]
		public int Id { get; set; }

		public string nom { get; set; }
		public string prenom { get; set; }
		public string adresse { get; set; }
	}
}
