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
	public class ServiceProduit : IProduitManager
	{
		private MyDbContext context = new MyDbContext();

		public Task<ProduitDto> Add(EntityDto entityDto)
		{
			throw new NotImplementedException();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public List<ProduitDto> getAll()
		{
			
			var produits = context.produits.ToList();

			var config = new MapperConfiguration(cfg =>
					cfg.CreateMap<Produit, ProduitDto>()
				);
			var mapper = config.CreateMapper();
			var res = mapper.Map<List<Produit>, List<ProduitDto>>(produits);
			return res;
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

		public Task<ProduitDto> Update(int id, EntityDto entityDto)
		{
			throw new NotImplementedException();
		}
	}
}
