using AutoMapper;
using Gestion_Devis_Traiteur;
using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Entity;
using GestionDevisTraiteurWPF.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestionDevisTraiteurWPF.Service
{
	class ServiceSousProduit : ISousProduitManager
	{

		private readonly MyDbContext context = (MyDbContext)Application.Current.Properties["dbContext"];

		private readonly IMapper mapper = (IMapper)Application.Current.Properties["Mapper"];

		public Task<SousProduitDto> Add(EntityDto entityDto)
		{
			throw new NotImplementedException();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<SousProduitDto> getAll()
		{
			throw new NotImplementedException();
		}

		public Task getById(int id)
		{
			throw new NotImplementedException();
		}

		public Task saveChanges()
		{
			throw new NotImplementedException();
		}

		public Task<SousProduitDto> Update(int id, EntityDto entityDto)
		{
			throw new NotImplementedException();
		}

		public List<SousProduitDto> GetSousProduitByProduit(int idProduit)
		{
			var sousProduits = context.sousProduits.Where(b => b.produit.id == idProduit).ToList();

			var res = mapper.Map<List<SousProduit>, List<SousProduitDto>>(sousProduits);
			return res;
		}
	}
}
