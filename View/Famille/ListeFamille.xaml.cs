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
	/// Logique d'interaction pour ListeFamille.xaml
	/// </summary>
	public partial class ListeFamille : Window
	{
		readonly ServiceFamille serviceFamille = new ServiceFamille();

		public ListeFamille()
		{

			InitializeComponent();
			List<FamilleDto> familleDtos = serviceFamille.GetAll();

			Familles.ItemsSource = familleDtos;
		}

		private void DataWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}

		private void NewFamille(object sender, RoutedEventArgs e)
		{
			FicheFamille fenetre = new FicheFamille(new FamilleDto());
			fenetre.Show();
		}

		private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
		{
			DataGridRow row = sender as DataGridRow;
			FamilleDto familleDto = (FamilleDto)row.DataContext;
			FicheFamille fenetre = new FicheFamille(familleDto);
			fenetre.Show();
		}
	}
}
