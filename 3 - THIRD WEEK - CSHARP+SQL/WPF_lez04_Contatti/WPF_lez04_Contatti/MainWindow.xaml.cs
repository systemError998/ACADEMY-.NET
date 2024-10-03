using System.Drawing;
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
using WPF_lez04_Contatti.Models;
using WPF_lez04_Contatti.Models.DAL;

namespace WPF_lez04_Contatti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Contatto> contatti = ContattoDAO.GetInstance().GetAll();
            areaContatti.ItemsSource = contatti;
        }

        private void btn_save_click(object sender, RoutedEventArgs e)
        {
            //prendo il valore degli input:
            string varNome = this.inputNome.Text;
            //eseguo un controllo sulla stringa presa in input
            if (inputNome.Text.Trim().Equals("")) {
                alert_message.Text = "Controlla il campo nome.";
                return;
            }

            string varCogn = this.inputCogn.Text;
            if (inputCogn.Text.Trim().Equals("")) {
                alert_message.Text = "Controlla il campo cognome.";
                return;
            }

            string varMail = this.inputMail.Text;
            if (inputMail.Text.Trim().Equals(""))
            {
                alert_message.Text = "Controlla il campo email.";
                return;
            }

            string varCodf = this.inputCodf.Text;
            if (inputCodf.Text.Trim().Equals(""))
            {
                alert_message.Text = "Controlla il campo codice fiscale.";
                return;
            }

            Contatto nuovoContatto = new Contatto()
            {
                Nome = varNome,
                Cognome = varCogn,
                Email = varMail,
                CodFis = varCodf
            };

            if (ContattoDAO.GetInstance().Insert(nuovoContatto))
            {
                MessageBox.Show("Inserimento effettuato con successo");
                this.inputNome.Text = "";
                this.inputCogn.Text = "";
                this.inputMail.Text = "";
                this.inputCodf.Text = "";

                areaContatti.ItemsSource = ContattoDAO.GetInstance().GetAll();
            }
            else
            {
                MessageBox.Show("Errore di inserimento");
            }
        }

        private void btn_close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_svuota_click(object sender, RoutedEventArgs e)
        {
            this.inputNome.Text = "";
            this.inputCogn.Text = "";
            this.inputMail.Text = "";
            this.inputCodf.Text = "";
        }

        private void inputCogn_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Modifica_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Elimina_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}