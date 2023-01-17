using Microsoft.Toolkit.Mvvm.ComponentModel;
using Personas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class VentanaListaVM : ObservableObject
    {

        private List<Persona> lista;

        public List<Persona> Lista
        {
            get { return lista; }
            set { SetProperty(ref lista, value); }
        }



        public VentanaListaVM()
        {
            Lista = new List<Persona>();
            Lista.Add(new Persona("Pietro", 30, "Italiana"));
            Lista.Add(new Persona("Julia", 25, "Española"));
            Lista.Add(new Persona("Sophie", 35, "Francesa"));

        }
    }
}
