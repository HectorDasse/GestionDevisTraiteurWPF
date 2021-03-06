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

namespace GestionDevisTraiteurWPF.View.Famille
{
	/// <summary>
	/// Logique d'interaction pour FicheFamille.xaml
	/// </summary>
	public partial class FicheFamille : Window
	{
		readonly ServiceProduit serviceProduit = new ServiceProduit();
		readonly ServiceFamille serviceFamille = new ServiceFamille();

		public FicheFamille(FamilleDto familleDto)
		{
			InitializeComponent();

			dataGridProduit.ItemsSource = serviceProduit.GetProduitByFamille(familleDto.id);
			this.Id.Text = familleDto.id.ToString();
			this.Nom.Text = familleDto.nom;
		}

		private void DataWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			foreach (var element in Application.Current.Windows)
			{
				if (element.ToString() == "GestionDevisTraiteurWPF.View.Famille.ListeFamille")
				{
					ListeFamille listeFamille = (ListeFamille)element;
					listeFamille.Familles.ItemsSource = null;
					listeFamille.chargeTab();
				}
			}
		}

		private void Valider(object sender, RoutedEventArgs e)
		{
			FamilleDto familleDto = new FamilleDto();
			familleDto.nom = this.Nom.Text;
			if (this.Id.Text == "0")
			{
				serviceFamille.AddFamille(familleDto);
			}
			else
			{
				familleDto.id = Convert.ToInt32(this.Id.Text);
				serviceFamille.UpdateFamille(familleDto);
			}
			this.Close();
		}
	}
}
