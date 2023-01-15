using Personas.Vistas;
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
        public UserControl CargaLista()
        {
            return new VentanaLista();
        }
        public UserControl CargaAñadir()
        {
            return new VentanaAñadir();
        }
    }
}
