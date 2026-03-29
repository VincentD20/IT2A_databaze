using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace evidence_knih
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        ObservableCollection<Cvik> cviky = new ObservableCollection<Cvik>();

        public MainWindow()
        {
            InitializeComponent();
            SkillsDataGrid.ItemsSource = cviky;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
         
            cviky.Add(new Cvik(Nazev.Text, Kategorie.Text, int.TryParse(Obtiznost.Text, out int obtiznost) ? obtiznost : 0, int.TryParse(Pocet_tydnu.Text, out int tydny) ? tydny : 0, Poznamka.Text, Splneno.IsChecked == true));
            Nazev.Text = "";
            Kategorie.Text = "";
            Obtiznost.Text = "";
            Pocet_tydnu.Text = "";
            Poznamka.Text = "";
            Splneno.IsChecked = false;

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Cvik vybrany = SkillsDataGrid.SelectedItem as Cvik;
            if (vybrany == null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(Nazev.Text))
            {
                vybrany.Nazev = Nazev.Text;
            }
            if (!string.IsNullOrEmpty(Kategorie.Text))
            {
                vybrany.Kategorie = Kategorie.Text;
            }
            if (!string.IsNullOrEmpty(Obtiznost.Text))
            {
                vybrany.Obtiznost = int.TryParse(Obtiznost.Text, out int obtiznost) ? obtiznost : 0;
            }
            if (!string.IsNullOrEmpty(Pocet_tydnu.Text))
            {
                vybrany.Tydny = int.TryParse(Pocet_tydnu.Text, out int tydny) ? tydny : 0;
            }
            if (!string.IsNullOrEmpty(Poznamka.Text))
            {
                vybrany.Poznamka = Poznamka.Text;
            }

            vybrany.Splneno = Splneno.IsChecked == true;




            SkillsDataGrid.Items.Refresh();

            Nazev.Text = "";
            Kategorie.Text = "";
            Obtiznost.Text = "";
            Pocet_tydnu.Text = "";
            Poznamka.Text = "";
            Splneno.IsChecked = false;

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Cvik vybrany = SkillsDataGrid.SelectedItem as Cvik;
            if (vybrany == null)
            {
                return;
            }
            cviky.Remove(vybrany);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            cviky.Clear();
        }
    }
}