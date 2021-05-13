using GestionDevisTraiteurWPF.View;
using GestionDevisTraiteurWPF.View.Client;
using GestionDevisTraiteurWPF.View.Famille;
using GestionDevisTraiteurWPF.View.Produit;
using System;
using System.Windows;

namespace GestionDevisTraiteurWPF
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ListeFamille(object sender, RoutedEventArgs e)
		{
			ListeFamille fenetre = new ListeFamille();
			fenetre.Show();
			this.Close();
		}

		private void ListeProduit(object sender, RoutedEventArgs e)
		{
			ListeProduits fenetre = new ListeProduits();
			fenetre.Show();
			this.Close();
		}

		private void ListeClient(object sender, RoutedEventArgs e)
		{
			ListeClient fenetre = new ListeClient();
			fenetre.Show();
			this.Close();
		}
	}
}
