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

namespace GestionDevisTraiteurWPF.Service
{
	class ServiceSousProduit : ISousProduitManager
	{

		private MyDbContext context = new MyDbContext();

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

			var config = new MapperConfiguration(cfg =>
					cfg.CreateMap<SousProduit, SousProduitDto>()
				);
			var mapper = config.CreateMapper();
			var res = mapper.Map<List<SousProduit>, List<SousProduitDto>>(sousProduits);
			return res;
		}
	}
}
