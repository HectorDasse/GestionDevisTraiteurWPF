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
	}
}
