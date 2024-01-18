using System;
using System.Windows;

namespace BorneLaPoste
{
    /// <summary>
    /// Logique d'interaction pour Suivi.xaml
    /// </summary>
    public partial class Suivi : Window
    {
        public Suivi(OrderData orderData)
        {
            InitializeComponent();
            Console.WriteLine(orderData.Price);
        }

        /// <summary>
        /// Return to the product window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnProductWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
