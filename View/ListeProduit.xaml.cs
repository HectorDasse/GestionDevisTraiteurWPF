using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Manager;
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

namespace GestionDevisTraiteurWPF.View
{
	/// <summary>
	/// Logique d'interaction pour ListeProduit.xaml
	/// </summary>
	public partial class ListeProduit : Window
	{
		readonly ServiceProduit serviceProduit = new ServiceProduit();

		public ListeProduit()
		{
			InitializeComponent();

			List<ProduitDto> produitDtos = serviceProduit.getAll();

			Produits.ItemsSource = produitDtos;
		}

		private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
		{
			DataGridRow row = sender as DataGridRow;
			ProduitDto produitDto = (ProduitDto)row.DataContext;
			FicheProduit fenetre = new FicheProduit(produitDto);
			fenetre.Show();
			this.Close();
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{

		}

		private void NewPropduit(object sender, RoutedEventArgs e)
		{
			FicheProduit fenetre = new FicheProduit(new ProduitDto());
			fenetre.Show();
			this.Close();
		}
	}
}
