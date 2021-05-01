using Gestion_Devis_Traiteur;
using GestionDevisTraiteurWPF.Dto;
using GestionDevisTraiteurWPF.Manager;
using GestionDevisTraiteurWPF.Service;
using GestionDevisTraiteurWPF.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

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

			ListeProduit fenetre = new ListeProduit();
			fenetre.Show();
			this.Close();
		}
	}
}
