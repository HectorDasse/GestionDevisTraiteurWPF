using AutoMapper;
using Gestion_Devis_Traiteur;
using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Entity;
using GestionDevisTraiteurWPF.Manager;
using GestionDevisTraiteurWPF.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestionDevisTraiteurWPF.Service
{
	public class ServiceProduit
	{
		private readonly MyDbContext context = (MyDbContext)Application.Current.Properties["dbContext"];

		private readonly IMapper mapper = (IMapper)Application.Current.Properties["Mapper"];

		public List<ProduitDto> getAll()
		{
			
			var produits = context.produits.ToList();

			var res = mapper.Map<List<Produit>, List<ProduitDto>>(produits);
			return res;
			throw new NotImplementedException();
		}

		public void AddProduit(ProduitDto produitDto)
		{
			
			var res = mapper.Map<ProduitDto, Produit>(produitDto);
			res.DateMiseAJour = DateTime.Today;
			context.produits.Add(res);
			context.SaveChanges();
		}

		public void UpdateProduit(ProduitDto produitDto)
		{
			Produit produit = context.produits.Find(produitDto.id);
			produit.nom = produitDto.nom;
			produit.prix = produitDto.prix;
			produit.famille = context.familles.Find(produitDto.famille.id);
			produit.DateMiseAJour = DateTime.Today;
			context.SaveChanges();
		}

		public List<ProduitDto> GetProduitByFamille(int idFamille)
		{
			var Produits = context.produits.Where(b => b.famille.id == idFamille).ToList();
			var res = mapper.Map<List<Produit>, List<ProduitDto>>(Produits);
			return res;
		}


		public FamilleDto getFamilleDtoProduit(int idProduit)
		{
			Produit produit = context.produits.Where(p => p.id == idProduit).Include("Famille").FirstOrDefault();

			var res = mapper.Map<Famille, FamilleDto>(produit.famille);
			return res;
		}
	}
}
