using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cartelera_de_Cine
{
    public class Jugador
    {
        string nombre;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}