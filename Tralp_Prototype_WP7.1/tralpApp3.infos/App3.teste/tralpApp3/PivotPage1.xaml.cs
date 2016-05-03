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
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
   
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

        private void assunto_GotFocus(object sender, RoutedEventArgs e)
        {
            assunto.Text = "";

        }

        private void assunto_LostFocus(object sender, RoutedEventArgs e)
        {
            if (assunto.Text == String.Empty)
            {
                assunto.Text = "Assunto";
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
                texto.Text = "Texto do e-mail";
            }

        }

        private void ListBox_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Enviado com sucesso!");
        }
    }
}