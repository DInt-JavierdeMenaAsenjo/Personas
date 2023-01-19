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

namespace Personas.Vistas.VentanaNacionalidades
{
    /// <summary>
    /// Lógica de interacción para VentanaNacionalidades.xaml
    /// </summary>
    public partial class VentanaNacionalidades : Window
    {
        private VentanaNacionalidadesVM vm;
        public VentanaNacionalidades()
        {
            InitializeComponent();
            vm = new VentanaNacionalidadesVM();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
