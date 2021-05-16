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

namespace GestionDevisTraiteurWPF.View.Produit
{
	/// <summary>
	/// Logique d'interaction pour ListeProduits.xaml
	/// </summary>
	public partial class ListeProduits : Window
	{
		readonly ServiceProduit serviceProduit = new ServiceProduit();

		public ListeProduits()
		{
			InitializeComponent();
			try
			{
				this.chargeTab();
			} catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

		}

		private void DataWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			MainWindow fenetre = new MainWindow();
			fenetre.Show();
		}

		private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
		{
			DataGridRow row = sender as DataGridRow;
			ProduitDto produitDto = (ProduitDto)row.DataContext;
			FicheProduit fenetre = new FicheProduit(produitDto);
			fenetre.Owner = this;
			fenetre.Show();
		}

		private void NewPropduit(object sender, RoutedEventArgs e)
		{
			FicheProduit fenetre = new FicheProduit(new ProduitDto());
			fenetre.Owner = this;
			fenetre.Show();
		}

		public void chargeTab()
		{
			List<ProduitDto> produitDtos = serviceProduit.getAll();

			Produits.ItemsSource = produitDtos;
		}
	}
}
