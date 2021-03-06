using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Service;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;


namespace GestionDevisTraiteurWPF.View.Produit
{
	/// <summary>
	/// Logique d'interaction pour FicheProduit.xaml
	/// </summary>
	public partial class FicheProduit : Window
	{

		readonly ServiceSousProduit serviceSousProduit = new ServiceSousProduit();
		readonly ServiceProduit serviceProduit = new ServiceProduit();
		readonly ServiceFamille serviceFamille = new ServiceFamille();

		public FicheProduit(ProduitDto produitDto)
		{
			InitializeComponent();

			dataGridSousProduit.ItemsSource = serviceSousProduit.GetSousProduitByProduit(produitDto.id);
			comboFamille.ItemsSource = serviceFamille.GetAll();

			this.Nom.Text = produitDto.nom;
			this.Prix.Text = produitDto.prix.ToString();
			this.Id.Text = produitDto.id.ToString();
			this.ProduitSimple.IsChecked = produitDto.ProduitSimple;

			//cherche le produit dans la base pour recup la famille
			if (produitDto.id != 0)
			{
				produitDto.famille = serviceProduit.getFamilleDtoProduit(produitDto.id);
				comboFamille.SelectedValue = produitDto.famille.id;
			}
		}

		private void DataWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			foreach (var element in Application.Current.Windows)
			{
				if (element.ToString() == "GestionDevisTraiteurWPF.View.Produit.ListeProduits")
				{
					ListeProduits listeProduits = (ListeProduits)element;
					listeProduits.Produits.ItemsSource = null;
					listeProduits.chargeTab();
				}
			}
		}

		private void Valider(object sender, RoutedEventArgs e)
		{

			FamilleDto familleDto = (FamilleDto)comboFamille.SelectedItem;


			ProduitDto produitDto = new ProduitDto();
			produitDto.nom = this.Nom.Text;
			produitDto.famille = familleDto;
			produitDto.ProduitSimple = (bool)this.ProduitSimple.IsChecked;
			string temp = this.Prix.Text.Replace(".", ",");
			produitDto.prix = Convert.ToDouble(temp);
			if (this.Id.Text == "0")
			{
				//check si le nom du produit existe déja
				if (serviceProduit.verifieProduitExiste(this.Nom.Text) == true)
				{
					MessageBox.Show("Ce produit exsite déja");
					return;
				}
				produitDto = serviceProduit.AddProduit(produitDto);
			}
			else
			{
				produitDto.id = Convert.ToInt32(this.Id.Text);
				produitDto = serviceProduit.UpdateProduit(produitDto);
			}
			saveSousProduit(produitDto);

			this.Close();
		}

		private void PrixValidationTextBox(object sender, TextCompositionEventArgs e)
		{
			Regex regex = new Regex("^[.][0-9]+$|^[0-9]*[.]{0,1}[0-9]*$");
			e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
		}

		private void saveSousProduit(ProduitDto produitDto)
		{
			for (int i = 0; i < dataGridSousProduit.Items.Count; i++)
			{
				try
				{
					SousProduitDto sousProduitDto = (SousProduitDto)dataGridSousProduit.Items[i];
					sousProduitDto.ProduitDto = produitDto;

					//cherche si la ligne existe déja en base
					if (sousProduitDto.id == 0)
					{
						serviceSousProduit.Add(sousProduitDto);
					}
					else
					{
						serviceSousProduit.Update(sousProduitDto);
					}
				} catch (Exception e)
				{
					Console.WriteLine(e);
				}
			}
		}
	}
}
