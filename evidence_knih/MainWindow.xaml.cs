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
            cviky.Add(new Cvik(Nazev.Text, Kategorie.Text, int.TryParse(Obtiznost.Text, out int obtiznost) ? obtiznost : 0, int.TryParse(Pocet_tydnu.Text, out int tydny) ? tydny : 0, Poznamka.Text, Splneno.IsChecked == true);
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}