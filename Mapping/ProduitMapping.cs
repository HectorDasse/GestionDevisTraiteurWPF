using AutoMapper;
using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Mapping
{
	public class ProduitMapping : Profile
	{
		public ProduitMapping()
		{

			CreateMap<Produit, ProduitDto>();

			CreateMap<Famille, FamilleDto>();

		}
	}
}
