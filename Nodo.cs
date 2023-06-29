using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplementeLigadas
{
     /*
        https://github.com/AntonioRogelUK/ED_Listas
     */

    public class Nodo
    {
        public string Valor { get; set; }
        public Nodo Enlace { get; set; }

        public Nodo(string valor = "", Nodo enlace = null)
        {
            Valor = valor;
            Enlace = enlace;
        }
    }
}

