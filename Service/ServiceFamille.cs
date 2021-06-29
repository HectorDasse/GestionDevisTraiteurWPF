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
	public class ServiceFamille
	{
		private readonly MyDbContext context = (MyDbContext)Application.Current.Properties["dbContext"];

		private readonly IMapper mapper = (IMapper)Application.Current.Properties["Mapper"];

		private ServiceProduit ServiceProduit = new ServiceProduit();

		public List<FamilleDto> GetAll()
		{
			List<Famille> familles =  context.familles.ToList();
			var res = mapper.Map<List<Famille>, List<FamilleDto>>(familles);
			return res;
		}

		public void AddFamille(FamilleDto familleDto)
		{

			var res = mapper.Map<FamilleDto, Famille>(familleDto);
			context.familles.Add(res);
			context.SaveChanges();
		}

		public void UpdateFamille(FamilleDto familleDto)
		{
			Famille famille = context.familles.Find(familleDto.id);
			famille.nom = familleDto.nom;
			context.SaveChanges();
		}

		public FamilleDto getFamilleById(int id)
		{
			Famille famille = context.familles.Find(id);
			var res = mapper.Map<Famille, FamilleDto>(famille);
			return res;
		}

		public void supprimer(FamilleDto familleDto)
		{
			List<ProduitDto> produitDtos = ServiceProduit.GetProduitByFamille(familleDto.id);

			FamilleDto familleDtoDefaut = getFamilleById(1);

			foreach (ProduitDto produitDto in produitDtos)
			{
				produitDto.famille = familleDtoDefaut;
				ServiceProduit.UpdateProduit(produitDto);
			}

			Famille famille = context.familles.Find(familleDto.id);
			context.familles.Remove(famille);
			context.SaveChanges();
		}
	}
}
