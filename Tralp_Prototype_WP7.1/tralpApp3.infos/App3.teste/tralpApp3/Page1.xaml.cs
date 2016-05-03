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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void texto1_GotFocus(object sender, RoutedEventArgs e)
        {
            texto1.Text = "";
        }

        private void texto1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (texto1.Text == String.Empty)
            {
                texto1.Text = "Digite seu texto";
            }
        }

        private void OnKeyDownHandler(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                this.lb.Items.Add(texto1.Text);
                texto1.Text = String.Empty;
            }
        }
    }
}