using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Entidades
{
    class Formateador : IFormateador
    {
        private string _id;

        public Formateador()
        {
            _id = Guid.NewGuid().ToString();
        }
        public string NombreCompleto(IEquipo equipo)
        {
            return $"Nombre completo {equipo.Nombre} ({equipo.Abreviatura}) {_id}";
        }
    }
}
