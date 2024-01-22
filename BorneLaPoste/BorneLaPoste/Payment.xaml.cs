using BorneLaPoste.Shared;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace BorneLaPoste
{
    /// <summary>
    /// Logique d'interaction pour Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public OrderData OrderData { get; set; }

        public Payment(OrderData updatingOrderData)
        {
            InitializeComponent();
            initPayment(updatingOrderData);
        }

        private void initPayment(OrderData updatingOrderData)
        {
            titlePayment.Content = $"Suivez les instructions pour le paiement par {updatingOrderData.Payment}";
            amountPayment.Content = $"Montant de votre commande = {updatingOrderData.Price} €";
            textPayment.Content = updatingOrderData.Payment == "pièces" ? "INSEREZ VOTRE MONNAIE" : "INSEREZ VOTRE CARTE BANCAIRE";

            var imageUri = updatingOrderData.Payment == "pièces" ? new Uri("pack://application:,,,/img/payment/pièces.png") : new Uri("pack://application:,,,/img/payment/cb.png");

            var bitmapImage = new BitmapImage(imageUri);
            imagePayment.Source = bitmapImage;

            OrderData = updatingOrderData;
        }

        /// <summary>
        /// Return to the payment choice window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnPaymentChoiceWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
