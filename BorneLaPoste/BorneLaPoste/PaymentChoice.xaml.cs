using BorneLaPoste.Shared;
using System.Windows;
using System.Windows.Controls;

namespace BorneLaPoste
{
    /// <summary>
    /// Logique d'interaction pour PaymentChoice.xaml
    /// </summary>
    public partial class PaymentChoice : Window
    {
        public OrderData OrderData { get; set; }

        public PaymentChoice(OrderData updatingOrderData)
        {
            InitializeComponent();
            OrderData = updatingOrderData;
        }

        /// <summary>
        /// Return to the order window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnOrderWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Open the payment window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentOpen(object sender, RoutedEventArgs e)
        {
            Utils utils = new Utils();
            bool isFormOpen = utils.IsAlreadyOpen(typeof(Payment));

            if (!isFormOpen)
            {
                Button clickedButton = sender as Button;
                string paymentChoice = clickedButton?.Tag?.ToString();
                OrderData.Payment = paymentChoice;

                Payment paymentForm = new Payment(OrderData);

                paymentForm.Owner = Application.Current.MainWindow;
                paymentForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                paymentForm.Show();
            }
        }
    }
}
