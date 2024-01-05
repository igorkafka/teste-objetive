using Objective.Domain.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using Objective.Domain.Composite.Component;
using System.Diagnostics.Eventing.Reader;
using Objective.Forms;
using System.ComponentModel;

namespace Objective
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            LoadAlimentos();
            InitializeComponent();
        }
        private void LoadAlimentos()
        {
            var lasanha = new Prato(Guid.NewGuid(), "Lasanha");
            var bolo = new Prato(Guid.NewGuid(), "Bolo de Chocolate");
            var tipoPratos = new List<TipoPrato> { new TipoPrato("Massa", lasanha), new TipoPrato("Doce", bolo) };
            compositePrato = new CompositePrato(tipoPratos);

        }
        public CompositePrato compositePrato;
        private void AcessarTiposAlimentos(IList<TipoPrato> tipoAlimentos )
        {
            TipoPrato CriarAlimentoEAlimento()
            {

                PratoNewForm pratoNewForm = new PratoNewForm();
                pratoNewForm.ShowDialog();
                Prato alimento = new Prato(Guid.NewGuid(), pratoNewForm.ResultValue);
                PratoTipoNewForm pratoTipoNewForm = new PratoTipoNewForm();
                pratoTipoNewForm.ShowDialog();
                TipoPrato tipoAlimento = new TipoPrato(pratoTipoNewForm.ResultValue, alimento);
                return tipoAlimento;
            }
            foreach (var component in tipoAlimentos)
            {
                var tipoAlimentoResponse = MessageBox.Show($"Seu Prato é {component.Nome} ", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (tipoAlimentoResponse == MessageBoxResult.Yes) 
                {
                    
                        var AlimentoResponse = MessageBox.Show($"Você pensou em {component.Alimento.Nome} ", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (AlimentoResponse == MessageBoxResult.Yes)
                        {
                            MessageBox.Show("Acertei!");
                            break;
                        }
                        else
                        {
                            if (compositePrato.AindaPossuiFilhos(component))
                                AcessarTiposAlimentos(component.TipoPratos);

                            else
                            {
                                var tipoAlimento = CriarAlimentoEAlimento();
                                component.Adicionar(tipoAlimento);
                            }
                            break;
                    }
                }
                else if (compositePrato.EhUltimo(component)) 
                {
                    var tipoAlimento = CriarAlimentoEAlimento();
                    tipoAlimentos.Add(tipoAlimento);
                    break;
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                AcessarTiposAlimentos(this.compositePrato.Components);
            }
        }
    }
}
