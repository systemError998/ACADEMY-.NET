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

namespace WPF_lez03_Interazione
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btn_Salva_Click(object sender, RoutedEventArgs e)
        {
            string varNome = this.txtNome.Text; // prendo l'input dell'input che ha il nome txtNome
            string varCognome = this.txtCognome.Text; // prendo l'input dell'input che ha il nome txtNome

            if (varNome.Trim().Equals("") || varCognome.Trim().Equals(""))
            {
                MessageBox.Show("Errore di inserimento nome o cognome"); //il messagebox è bloccante (interrapt) 
                return;
            }
            else {
                tb_risultato.Text = $"I valori inseriti sono {varNome} {varCognome}";
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}