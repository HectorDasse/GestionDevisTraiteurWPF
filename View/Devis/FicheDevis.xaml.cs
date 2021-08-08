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

namespace GestionDevisTraiteurWPF.View.Devis
{
	/// <summary>
	/// Logique d'interaction pour FicheDevis.xaml
	/// </summary>
	public partial class FicheDevis : Window
	{

		readonly ServiceDevis serviceDevis = new ServiceDevis();

		public FicheDevis(DevisDto devisDto)
		{
			InitializeComponent();

			this.Nom.Text = devisDto.nom;

		}

		private void Valider(object sender, RoutedEventArgs e)
		{

		}
	}
}
