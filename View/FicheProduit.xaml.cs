using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
		readonly ServiceProduit serviceProduit = new ServiceProduit();
		readonly ServiceFamille serviceFamille = new ServiceFamille();

		public FicheProduit(ProduitDto produit)
		{
			InitializeComponent();

			dataGridSousProduit.ItemsSource = serviceSousProduit.GetSousProduitByProduit(produit.id);
			comboFamille.ItemsSource = serviceFamille.GetAll();

			this.Nom.Text = produit.nom;
			this.Prix.Text = produit.prix.ToString();
			this.Id.Text = produit.id.ToString();
			comboFamille.SelectedItem = produit.famille;

		}

		private void DataWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ListeProduit fenetre = new ListeProduit();
			fenetre.Show();
		}

		private void Valider(object sender, RoutedEventArgs e)
		{
			FamilleDto familleDto = (FamilleDto)comboFamille.SelectedItem;
			

			ProduitDto produitDto = new ProduitDto();
			produitDto.nom = this.Nom.Text;
			produitDto.famille = familleDto;
			string temp = this.Prix.Text.Replace(".", ",");
			produitDto.prix = Convert.ToDouble(temp);
			if (this.Id.Text == "0")
			{
				serviceProduit.AddProduit(produitDto);
			} else
			{
				produitDto.id = Convert.ToInt32(this.Id.Text);
				serviceProduit.UpdateProduit(produitDto);
			}
			ListeProduit fenetre = new ListeProduit();
			fenetre.Show();
			this.Close();
		}

		private void PrixValidationTextBox(object sender, TextCompositionEventArgs e)
		{
			Regex regex = new Regex("^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$");
			e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
		}
	}
}
