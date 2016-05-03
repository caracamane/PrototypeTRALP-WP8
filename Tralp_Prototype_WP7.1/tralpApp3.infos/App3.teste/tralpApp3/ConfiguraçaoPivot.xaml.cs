using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace tralpApp3
{
    public partial class PivotPage2 : PhoneApplicationPage
    {
        public PivotPage2()
        {
            InitializeComponent();
        }

        private void nome_GotFocus(object sender, RoutedEventArgs e)
        {
            nome.Text = "";
        }

        private void nome_LostFocus(object sender, RoutedEventArgs e)
        {
            if (nome.Text == String.Empty)
            {
                nome.Text = "Nome";
            }

        }

        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            email.Text = "";

        }

        private void email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text == String.Empty)
            {
                email.Text = "E-mail";
            }

        }

        private void sugest_GotFocus(object sender, RoutedEventArgs e)
        {
            sugestão.Text = "";

        }

        private void sugest_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sugestão.Text == String.Empty)
            {
                sugestão.Text = "";
            }

        }

        private void gravar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gravado com sucesso!");
        }

        private void enviar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Enviado com sucesso!");
        }
    }
}