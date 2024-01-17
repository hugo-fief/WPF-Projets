using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shell;

namespace CalculatricePC
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string number = "";
        private List<int> numsList = new List<int>();
        private string sign = "";

        /// <summary>
        /// Fonction principale
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fonction qui gère les nombres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneralNumHandler(object sender, EventArgs e)
        {
            number = ((Button)sender).Content.ToString();
            numsList.Add(int.Parse(number));
            showNum(true);
        }

        /// <summary>
        /// Fonction qui affiche le nombre ou le signe
        /// </summary>
        private void showNum(bool isNumber)
        {
            if (isNumber)
            {
                textBoxRes.Text += number.ToString();
            } 
            else 
            {
                textBoxRes.Text += sign;
            }
        }

        /// <summary>
        /// Fonction qui gère les opérations pour les signes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneralSignHandler(object sender, EventArgs e)
        {
            sign = (string)((Button)sender).Content;
            showNum(false);
        }

        /// <summary>
        /// Fonction qui gère les opérations pour effacer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneralClearHandler(object sender, EventArgs e)
        {
            textBoxRes.Text = "";
        }

        /// <summary>
        /// Fonction qui gère les opérations pour le sign égal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneralEqualHandler(object sender, EventArgs e)
        {
            int result = 0;
            switch (sign)
            {
                case "+":
                    numsList.ForEach(num => result += num);
                    break;
                case "-":
                    numsList.ForEach(num => result -= num);
                    break;
                case "*":
                    numsList.ForEach(num => result *= num);
                    break;
                case "/":
                    numsList.ForEach(num => result /= num);
                    break;
            }

            numsList = new List<int>();
            textBoxRes.Text = "Résultat : " + result;
        }
    }
}
