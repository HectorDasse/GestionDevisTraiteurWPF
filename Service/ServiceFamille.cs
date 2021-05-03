﻿using AutoMapper;
using Gestion_Devis_Traiteur;
using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDevisTraiteurWPF.Service
{
	public class ServiceFamille
	{
		private MyDbContext context = new MyDbContext();

		public List<FamilleDto> GetAll()
		{
			List<Famille> familles =  context.familles.ToList();
			var config = new MapperConfiguration(cfg =>
					cfg.CreateMap<Famille, FamilleDto>()
				);
			var mapper = config.CreateMapper();
			var res = mapper.Map<List<Famille>, List<FamilleDto>>(familles);
			return res;
		}
	}
}
