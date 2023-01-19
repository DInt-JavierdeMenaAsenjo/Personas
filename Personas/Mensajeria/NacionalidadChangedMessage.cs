using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Mensajeria
{
    class NacionalidadChangedMessage : ValueChangedMessage<String>
    {
        public NacionalidadChangedMessage(String nacionalidad) : base(nacionalidad) { }
    }
}
