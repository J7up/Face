﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Face.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAuth.xaml
    /// </summary>
    public partial class PageAuth : Page
    {
        public PageAuth()
        {
            InitializeComponent();
        }

        private void BntAdmin_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFraim.Navigate(new PageAdmin());
        }

        private void BntGuest_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFraim.Navigate(new PageAdmin());
        }
    }
}
