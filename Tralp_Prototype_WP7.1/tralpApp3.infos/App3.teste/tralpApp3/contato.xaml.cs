using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace tralpApp3
{
    public partial class Page3 : PhoneApplicationPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void nome_LostFocus(object sender, RoutedEventArgs e)
        {
            if (nome.Text == String.Empty)
            {
                nome.Text = "Digite seu texto";
            }

        }

        private void nome_GotFocus(object sender, RoutedEventArgs e)
        {
            nome.Text = "";

        }

        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            email.Text = "";

        }

        private void email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text == String.Empty)
            {
                email.Text = "Digite seu texto";
            }

        }

        private void assunto_GotFocus(object sender, RoutedEventArgs e)
        {
            assunto.Text = "";

        }

        private void assunto_LostFocus(object sender, RoutedEventArgs e)
        {
            if (assunto.Text == String.Empty)
            {
                assunto.Text = "Digite seu texto";
            }

        }

        private void texto_GotFocus(object sender, RoutedEventArgs e)
        {
            texto.Text = "";

        }

        private void texto_LostFocus(object sender, RoutedEventArgs e)
        {
            if (texto.Text == String.Empty)
            {
                texto.Text = "Digite seu texto";
            }

        }
    }
}