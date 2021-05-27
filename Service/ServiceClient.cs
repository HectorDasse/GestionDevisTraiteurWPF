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
	class ServiceClient
	{

		private readonly MyDbContext context = (MyDbContext)Application.Current.Properties["dbContext"];

		private readonly IMapper mapper = (IMapper)Application.Current.Properties["Mapper"];

		public List<ClientDto> GetAll()
		{
			List<Client> clients = context.clients.ToList();

			var res = mapper.Map<List<Client>, List<ClientDto>>(clients);
			return res;
		}

		public void AddClient(ClientDto clientDto)
		{
			var config = new MapperConfiguration(cfg =>
					cfg.CreateMap<ClientDto, Client>()
				);
			var mapper = config.CreateMapper();

			var res = mapper.Map<ClientDto, Client>(clientDto);
			context.clients.Add(res);
			context.SaveChanges();
		}

		public void UpdateClient(ClientDto clientDto)
		{
			Client client = context.clients.Find(clientDto.id);
			client.nom = clientDto.nom;
			client.prenom = clientDto.prenom;
			client.adresse = clientDto.adresse;
			context.SaveChanges();
		}
	}
}
