using System;

namespace Prode.Core.Entidades
{
    public class Partido
    {
        public Equipo EquipoLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public DateTime Fecha { get; set; }

        public string InformarResultado
        {
            get
            {
                var resultado = "";
                if (GolesLocal > GolesVisitante)
                {
                    resultado = $"Ganó {EquipoLocal.Nombre}";
                }
                else if (GolesLocal < GolesVisitante)
                {
                    resultado = $"Ganó {EquipoVisitante.Nombre}";
                }
                else
                {
                    resultado = "Empate";
                }
                return resultado;
            }
        }
    }
}
