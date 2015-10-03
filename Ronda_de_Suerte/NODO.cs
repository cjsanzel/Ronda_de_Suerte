using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ronda_de_Suerte
{
    class NODO
    {
        string jugador;

        NODO sig;

        public NODO(string jug)//constructor
        {
            jugador = jug;

            sig = null;
        }

        public string get_jugador()
        {
            return jugador;
        }

        public void set_sig(NODO punt)
        {
            sig = punt;
        }

        public NODO get_sig()
        {
            return sig;
        }
    }
}
