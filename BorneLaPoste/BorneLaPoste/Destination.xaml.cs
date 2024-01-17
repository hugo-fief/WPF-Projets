using System.Windows;

namespace BorneLaPoste
{
    /// <summary>
    /// Logique d'interaction pour Destination.xaml
    /// </summary>
    public partial class Destination : Window
    {
        public Destination()
        {
            InitializeComponent();
        }

        private void ReturnMainWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
