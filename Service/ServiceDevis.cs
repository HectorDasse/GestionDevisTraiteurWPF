using AutoMapper;
using Gestion_Devis_Traiteur;
using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestionDevisTraiteurWPF.Service
{
	class ServiceDevis
	{
		private readonly MyDbContext context = (MyDbContext)Application.Current.Properties["dbContext"];

		private readonly IMapper mapper = (IMapper)Application.Current.Properties["Mapper"];

		public List<DevisDto> GetAll()
		{
			List<Devis> devis = context.devis.ToList();

			var res = mapper.Map<List<Devis>, List<DevisDto>>(devis);
			return res;
		}
	}
}
