using System.Windows;

namespace BorneLaPoste
{
    /// <summary>
    /// Logique d'interaction pour Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public OrderData OrderData { get; set; }

        public Order(OrderData updatingOrderData)
        {
            InitializeComponent();
            OrderData = updatingOrderData;
        }

        /// <summary>
        /// Return to the suivi window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnSuiviWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
