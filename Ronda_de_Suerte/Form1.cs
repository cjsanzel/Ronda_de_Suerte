using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ronda_de_Suerte
{
    public partial class FRM_RONDA_DE_SUERTE : Form
    {
        PARTICIPANTE P;
        //mejorar mi codigo
        //vamos que se puede
        // mata a la rata de tu izquierda
        bool bandera;

        public FRM_RONDA_DE_SUERTE()
        {

            P = new PARTICIPANTE();

            bandera = false;
            
            InitializeComponent();
        }

        private void BTO_PARTICIPANTE_Click(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                MessageBox.Show("EL JUEGO EMPEZO...ESPERE A QUE TERMINE", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_PARTICIPANTE.Clear();

                TXT_PARTICIPANTE.Focus();
            }
            else
            {

                string d;

                if (TXT_PARTICIPANTE.Text == "")
                {
                    MessageBox.Show("INGRESE UN DATO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_PARTICIPANTE.Focus();
                }
                else
                {
                    d = TXT_PARTICIPANTE.Text;

                    P.crear_lista(d);

                    TXT_PARTICIPANTE.Clear();

                    TXT_PARTICIPANTE.Focus();

                    LST_PARTICIPANTES.Items.Clear();

                    mostrar();
                }
            }

        }

        private void TXT_PARTICIPANTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BTO_PARTICIPANTE.Focus();                
            }

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
                    {
                        MessageBox.Show("Solo se permite LETRAS", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TXT_PARTICIPANTE.Focus();
                        e.Handled = true;

                    }
                }
            }
        }
        

        private void BTO_MOSTRAR_Click(object sender, EventArgs e)
        {
            LST_PARTICIPANTES.Items.Clear();
            mostrar();
        }

        private void mostrar()
        {
            NODO aux, aux_cabeza;

            aux_cabeza = P.devolver_cabeza();

            aux = P.devolver_cabeza();

            if (aux == null)
            {
                MessageBox.Show("LA LISTA ESTÁ VACIA", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TXT_PARTICIPANTE.Focus();
            }

            else
            {

                do
                {
                    LST_PARTICIPANTES.Items.Add(aux.get_jugador());
                    aux = aux.get_sig();

                } while (aux != aux_cabeza);


            }
        }        


        

        private void BTO_JUGAR_Click(object sender, EventArgs e)
        {
            int d;          

            dado x = new dado();
            NODO aux_cabeza;
            aux_cabeza = P.devolver_cabeza();            

            LBL_DADO.Text = x.jugar().ToString();

            d = int.Parse(LBL_DADO.Text);

            if (P.devolver_cabeza() == null)
            {
                LBL_DADO.Text ="---" ;
                mostrar();
            }
            else
            {
                bandera = true;
                if (aux_cabeza != aux_cabeza.get_sig())
                {
                    
                    MessageBox.Show("* * EL Jugador * *" + P.eliminar(d) + " HA SIDO ELIMINADO ", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    LST_PARTICIPANTES.Items.Clear();

                    mostrar();
                }

                else
                {

                    LBL_DADO.Text = "---";                  

                    MessageBox.Show("* * EL Jugador * *" + P.eliminar(d) + " ES EL GANADOR ", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    MessageBox.Show("EL JUEGO HA TERMINADO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LST_PARTICIPANTES.Items.Clear();
               
                    mostrar();

                    LST_PARTICIPANTES.Items.Clear();
               
                }
            }
        }

        private void BTO_SALIR_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
       
    }
}
