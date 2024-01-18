using System;
using System.Windows;
using System.Windows.Controls;

namespace BorneLaPoste
{
    /// <summary>
    /// Logique d'interaction pour Suivi.xaml
    /// </summary>
    public partial class Suivi : Window
    {
        public OrderData OrderData { get; set; }

        public Suivi(OrderData updatingOrderData)
        {
            InitializeComponent();
            OrderData = updatingOrderData;
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

        /// <summary>
        /// Open the order window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderOpen(object sender, RoutedEventArgs e)
        {
            Utils utils = new Utils();
            bool isFormOpen = utils.IsAlreadyOpen(typeof(Order));

            if (!isFormOpen)
            {
                Button clickedButton = sender as Button;
                decimal price = decimal.Parse(clickedButton?.Tag?.ToString());
                decimal total = price + OrderData.Price;

                OrderData orderData = new OrderData { Price = total };

                Order orderForm = new Order(orderData);

                orderForm.Owner = Application.Current.MainWindow;
                orderForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                orderForm.Show();
            }
        }
    }
}
