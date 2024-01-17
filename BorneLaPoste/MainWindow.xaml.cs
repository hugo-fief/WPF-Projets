﻿using System.Windows;

namespace BorneLaPoste
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open the destination window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DestionationOpen(object sender, RoutedEventArgs e)
        {
            Utils utils = new Utils();
            bool isFormOpen = utils.IsAlreadyOpen(typeof(Destination));
            if (!isFormOpen)
            {
                Destination destinationForm = new Destination();

                destinationForm.Owner = Application.Current.MainWindow;
                destinationForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                destinationForm.Show();
            }
        }
    }
}