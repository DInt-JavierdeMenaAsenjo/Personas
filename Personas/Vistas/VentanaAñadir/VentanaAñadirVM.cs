using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class VentanaAñadirVM : ObservableObject
    {
        ServicioNavegacion sn = new ServicioNavegacion();
        public RelayCommand NacionalidadCommand { get; }
        private List<String> nacionalidades;

        public List<String> Nacionalidades
        {
            get { return nacionalidades; }
            set { nacionalidades = value; }
        }
        public VentanaAñadirVM()
        {
            NacionalidadCommand = new RelayCommand(CargarNacionalidades);
            Nacionalidades = new List<String>();
            Nacionalidades.Add("Italiana");
            Nacionalidades.Add("Española");
            Nacionalidades.Add("Francesa");
        }

        public void CargarNacionalidades()
        {
            sn.AbrirVentanaNacionalidades();
        }
    }
}
