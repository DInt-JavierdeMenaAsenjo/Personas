using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Mensajeria;
using Personas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vistas.VentanaConsulta
{
    class VentanaConsultaVM : ObservableObject
    {
        private Persona personaMostrar;

        public Persona PersonaMostrar
        {
            get { return personaMostrar; }
            set { SetProperty(ref personaMostrar, value); }
        }

        public VentanaConsultaVM()
        {
            PersonaMostrar = WeakReferenceMessenger.Default.Send<PersonaChangedMessage>();
        }

    }
}
