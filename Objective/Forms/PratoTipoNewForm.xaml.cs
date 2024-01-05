using System;
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
    /// Interaction logic for PratoTipoNewForm.xaml
    /// </summary>
    public partial class PratoTipoNewForm : Window
    {
        public string ResultValue { get; private set; }

        public PratoTipoNewForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultValue = text_type_plate.Text;
            Close();
        }

        private void text_type_plate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
