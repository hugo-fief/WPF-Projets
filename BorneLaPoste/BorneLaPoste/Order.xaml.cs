using System.Windows;
using System.Windows.Controls;
using BorneLaPoste.Shared;

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
            InitOrder(updatingOrderData);
        }

        /// <summary>
        /// Init the order
        /// </summary>
        /// <param name="orderData"></param>
        private void InitOrder(OrderData updatingOrderData)
        {
            basketName.Content = updatingOrderData.Name;
            basketPrice.Content = updatingOrderData.Price;
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

        /// <summary>
        /// Increase the quantity of the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IncreaseQuantity(object sender, RoutedEventArgs e)
        {
            string currentQuantity = basketQuantity.Text;
            int updatedQuantity = int.Parse(currentQuantity) + 1;
            basketQuantity.Text = updatedQuantity.ToString();

            basketPrice.Content = OrderData.Price * updatedQuantity;
        }

        /// <summary>
        /// Increase the quantity of the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecreaseQuantity(object sender, RoutedEventArgs e)
        {
            string currentQuantity = basketQuantity.Text;
            int updatedQuantity = int.Parse(currentQuantity) - 1;
            basketQuantity.Text = updatedQuantity.ToString();
        }

        /// <summary>
        /// Open the payment choice window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentChoiceOpen(object sender, RoutedEventArgs e)
        {
            Utils utils = new Utils();
            bool isFormOpen = utils.IsAlreadyOpen(typeof(PaymentChoice));

            if (!isFormOpen)
            {
                PaymentChoice paymentChoiceForm = new PaymentChoice(OrderData);

                paymentChoiceForm.Owner = Application.Current.MainWindow;
                paymentChoiceForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                paymentChoiceForm.Show();
            }
        }
    }
}
