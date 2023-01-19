using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Mensajeria;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class VentanaAñadirVM : ObservableObject
    {
        ServicioNavegacion sn = new ServicioNavegacion();
        public RelayCommand NacionalidadCommand { get; }
        private ObservableCollection<String> nacionalidades;

        public ObservableCollection<String> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }
        public VentanaAñadirVM()
        {
            NacionalidadCommand = new RelayCommand(CargarNacionalidades);
            Nacionalidades = new ObservableCollection<String>();
            Nacionalidades.Add("Italiana");
            Nacionalidades.Add("Española");
            Nacionalidades.Add("Francesa");
            WeakReferenceMessenger.Default.Register<NacionalidadChangedMessage>(this, (r, m) =>
            {
                Nacionalidades.Add(m.Value);
            });
        }

        public void CargarNacionalidades()
        {
            sn.AbrirVentanaNacionalidades();
        }
    }
}
