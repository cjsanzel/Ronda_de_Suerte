using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ronda_de_Suerte
{
    class PARTICIPANTE
    {
        NODO cabeza, ultimo, nuevo;

        public PARTICIPANTE()
        {
            cabeza = null;
            nuevo = null;
            ultimo = new NODO("");
        }

        public void crear_lista(string jug)
        {
            nuevo = new NODO(jug);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }

            else
            {
                ultimo.set_sig(nuevo);
            }
            ultimo = nuevo;
            ultimo.set_sig(cabeza);
        }
        
        public NODO devolver_cabeza()
        {
            return cabeza;
        }

        public string eliminar(int d)
        {
            int cont;

            cont = 0;

            NODO post, aux_post, ant;            

            post = cabeza;

            ant = cabeza;
           
            while (cont < d)
            {
                if (cont < (d - 1))
                {
                    ant = ant.get_sig();
                }

                post = post.get_sig();

                cont++;
            }

            aux_post = post;
            post = post.get_sig();
            cabeza = post;
            aux_post.set_sig(null);
            ant.set_sig(cabeza);
            
            return aux_post.get_jugador();

        }

        
    }
}
