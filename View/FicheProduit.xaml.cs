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

namespace GestionDevisTraiteurWPF.View
{
	/// <summary>
	/// Logique d'interaction pour FicheProduit.xaml
	/// </summary>
	public partial class FicheProduit : Window
	{

		readonly ServiceSousProduit serviceSousProduit = new ServiceSousProduit();

		public FicheProduit(ProduitDto produit)
		{
			InitializeComponent();

			this.Nom.Text = produit.nom;
			this.Prix.Text = produit.prix.ToString();

			List<SousProduitDto> produitDtos = serviceSousProduit.GetSousProduitByProduit(produit.id);

			dataGridSousProduit.ItemsSource = produitDtos;
		}

		private void DataWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ListeProduit fenetre = new ListeProduit();
			fenetre.Show();
		}
	}
}
