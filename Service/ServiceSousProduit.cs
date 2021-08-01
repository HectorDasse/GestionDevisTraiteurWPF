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
	class ServiceSousProduit
	{

		private readonly MyDbContext context = (MyDbContext)Application.Current.Properties["dbContext"];

		private readonly IMapper mapper = (IMapper)Application.Current.Properties["Mapper"];

		public void Add(SousProduitDto sousProduitDto)
		{
			var res = mapper.Map<SousProduitDto, SousProduit>(sousProduitDto);
			res.DateMiseAJour = DateTime.Today;
			res.produit = context.produits.Find(sousProduitDto.ProduitDto.id);
			context.sousProduits.Add(res);
			context.SaveChanges();
		}

		public void Delete(int id)
		{
			SousProduit sousProduit = context.sousProduits.Find(id);
			context.sousProduits.Remove(sousProduit);
			context.SaveChanges();
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

		public void Update(SousProduitDto sousProduitDto)
		{
			SousProduit sousProduit = context.sousProduits.Find(sousProduitDto.id);
			sousProduit.nom = sousProduitDto.nom;
			sousProduit.prix = sousProduitDto.prix;
			sousProduit.produit = context.produits.Find(sousProduitDto.ProduitDto.id);
			sousProduit.DateMiseAJour = DateTime.Today;
			sousProduit.poids = sousProduitDto.poids;
			sousProduit.quantite = sousProduitDto.quantite;
			context.SaveChanges();
		}

		public List<SousProduitDto> GetSousProduitByProduit(int idProduit)
		{
			var sousProduits = context.sousProduits.Where(b => b.produit.id == idProduit).ToList();

			var res = mapper.Map<List<SousProduit>, List<SousProduitDto>>(sousProduits);
			return res;
		}
	}
}
