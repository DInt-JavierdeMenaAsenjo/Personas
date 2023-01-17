using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        private ServicioNavegacion sn;

        public RelayCommand NuevaCommand { get; }
        public RelayCommand ListaCommand { get; }
        

        private UserControl contenidoMostrar;

        public UserControl ContenidoMostrar
        {
            get { return contenidoMostrar; }
            set { SetProperty(ref contenidoMostrar, value); }
        }

        public MainWindowVM()
        {
            NuevaCommand = new RelayCommand(CargarNueva);
            ListaCommand = new RelayCommand(CargarLista);
            sn = new ServicioNavegacion();
        }

        public void CargarNueva()
        {
            ContenidoMostrar = sn.CargaAñadir();
        }

        public void CargarLista()
        {
            ContenidoMostrar = sn.CargaLista();
        }

    }
}
