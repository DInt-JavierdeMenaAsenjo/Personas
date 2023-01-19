using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Mensajeria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vistas.VentanaNacionalidades
{
    class VentanaNacionalidadesVM : ObservableObject
    {
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public RelayCommand addNacionalidadCommand { get; }
        public VentanaNacionalidadesVM()
        {
            addNacionalidadCommand = new RelayCommand(AddNacionalidad);
        }

        public void AddNacionalidad()
        {
            WeakReferenceMessenger.Default.Send(new NacionalidadChangedMessage(Nacionalidad));
        }
    }
}
