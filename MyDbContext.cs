using Gestion_Devis_Traiteur.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Devis_Traiteur
{
	class MyDbContext : DbContext
	{
		public DbSet<Client> clients { get; set; }

		public DbSet<Produit> produits { get; set; }

		public DbSet<Famille> familles { get; set; }

		public DbSet<Devis> devis { get; set; }

		public DbSet<ProduitDevis> produitDevis { get; set; }
	}
}
