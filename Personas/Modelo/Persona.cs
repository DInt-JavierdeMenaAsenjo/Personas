using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Modelo
{
    class Persona : ObservableObject
    {
        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
        private int edad;
        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }
        private String nacionalidad;
        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public Persona(String nombre, int edad, String nacionalidad) {
            this.nombre = nombre;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
        }

        override public String ToString()
        {
            return nombre + " - " + edad + " - " + nacionalidad;
        }
    }
}
