using System.Runtime.InteropServices;
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
using VerificaGit;

namespace ProvaGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            Nome.Text = biblioteca.Nome;
            Indirizzo.Text = biblioteca.Indirizzo;
            apertura.Text=biblioteca.Apertura;
            chiusura.Text= biblioteca.Chiusura;
        }

        Biblioteca biblioteca = new Biblioteca("Biblioteca Baldini", "via ugo rossi 1", "9:00", "18:00");   //errore a causa di livello di protezione

        private void aggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.Add(autore.Text,titolo.Text,annoPubblicazione.Text,editore.Text,numeroPagine.Text);

        }

        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lista.Items.Clear();

            for (int i = 0; i < biblioteca.numeroLibri(); i++)
            {
                lista.Items.Add(libri[i]);
            }
        }
    }
}