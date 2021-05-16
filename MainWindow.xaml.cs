﻿using Gestion_Devis_Traiteur;
using GestionDevisTraiteurWPF.View;
using GestionDevisTraiteurWPF.View.Client;
using GestionDevisTraiteurWPF.View.Famille;
using GestionDevisTraiteurWPF.View.Produit;
using System;
using System.Diagnostics;
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
			Application.Current.Properties["dbContext"] = new MyDbContext();
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

		private void Scrapping(object sender, RoutedEventArgs e)
		{
			var psi = new ProcessStartInfo();
			psi.FileName = @"C:\Users\hecto\AppData\Local\Programs\Python\Python39-32\python.exe";
			var script = @"A:\ScrappingGestionDevis\Main.py";
			psi.UseShellExecute = false;
			psi.CreateNoWindow = true;
			psi.RedirectStandardOutput = true;
			psi.RedirectStandardError = true;

			psi.Arguments = $"\"{script}";

			var errors = "";
			var results = "";
			using (var process = Process.Start(psi))
			{
				errors = process.StandardError.ReadToEnd();
				results = process.StandardOutput.ReadToEnd();
			}
		}
	}
}
