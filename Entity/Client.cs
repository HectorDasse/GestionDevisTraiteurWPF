using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Devis_Traiteur.Entity
{
	class Client
	{
		[Key]
		public int Id { get; set; }

		public String nom { get; set; }
		public String prenom { get; set; }
		public String adresse { get; set; }
	}
}
