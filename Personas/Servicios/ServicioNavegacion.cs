using Personas.Vistas;
using Personas.Vistas.VentanaConsulta;
using Personas.Vistas.VentanaNacionalidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {
        VentanaLista lista = new VentanaLista();
        public UserControl CargaLista()
        {
            return lista;
        }
        
        public UserControl CargaAñadir()
        {
            return new VentanaAñadir();
        }

        public UserControl CargaConsulta()
        {
            return new VentanaConsulta();
        }

        public bool? AbrirVentanaNacionalidades()
        {
            VentanaNacionalidades nueva = new VentanaNacionalidades();
            return nueva.ShowDialog();
        }
    }
}
