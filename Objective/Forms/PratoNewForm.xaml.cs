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
using System.Windows.Shapes;

namespace Objective.Forms
{
    /// <summary>
    /// Interaction logic for PratoNewForm.xaml
    /// </summary>
    public partial class PratoNewForm : Window
    {
        public string ResultValue { get; private set; }
        public PratoNewForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultValue = text_plate.Text;
            Close();
        }

        private void text_plate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
