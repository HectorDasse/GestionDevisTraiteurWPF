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

namespace GestionDevisTraiteurWPF.View.Devis
{
	/// <summary>
	/// Logique d'interaction pour ListeDevis.xaml
	/// </summary>
	public partial class ListeDevis : Window
	{
		private ServiceDevis ServiceDevis = new ServiceDevis();

		public ListeDevis()
		{
			InitializeComponent();
		}

		private void NewDevis(object sender, RoutedEventArgs e)
		{

		}

		private void SupprimerDevis(object sender, RoutedEventArgs e)
		{

		}

		internal void ChargeTab()
		{
			List<DevisDto> devisDtos = ServiceDevis.GetAll();

			Clients.ItemsSource = devisDtos;
		}
	}
}
