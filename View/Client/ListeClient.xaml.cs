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
	/// Logique d'interaction pour ListeClient.xaml
	/// </summary>
	public partial class ListeClient : Window
	{

		readonly ServiceClient serviceClient = new ServiceClient();

		public ListeClient()
		{
			InitializeComponent();
			List<ClientDto> clientDtos = serviceClient.GetAll();

			Clients.ItemsSource = clientDtos;
		}

		private void NewClient(object sender, RoutedEventArgs e)
		{
			FicheClient fenetre = new FicheClient(new ClientDto());
			fenetre.Show();
		}

		private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
		{
			DataGridRow row = sender as DataGridRow;
			ClientDto clientDto = (ClientDto)row.DataContext;
			FicheClient fenetre = new FicheClient(clientDto);
			fenetre.Show();
		}
	}
}
