using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GestionDevisTraiteurWPF.View.Client
{
	/// <summary>
	/// Logique d'interaction pour FicheClient.xaml
	/// </summary>
	public partial class FicheClient : Window
	{

		readonly ServiceClient serviceClient = new ServiceClient();

		public FicheClient(ClientDto clientDto)
		{
			InitializeComponent();
			this.Id.Text = clientDto.id.ToString();
			this.Nom.Text = clientDto.nom;
			this.Prenom.Text = clientDto.prenom;
			this.Adresse.Text = clientDto.adresse;
		}

		private void Valider(object sender, RoutedEventArgs e)
		{
			ClientDto clientDto = new ClientDto();
			clientDto.nom = this.Nom.Text;
			clientDto.prenom = this.Prenom.Text;
			clientDto.adresse = this.Adresse.Text;
			if (this.Id.Text == "0")
			{
				serviceClient.AddClient(clientDto);
			}
			else
			{
				clientDto.id = Convert.ToInt32(this.Id.Text);
				serviceClient.UpdateClient(clientDto);
			}
			this.Close();
		}

		private void DataWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
	}
}
