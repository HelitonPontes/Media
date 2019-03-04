using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public class Media
    {
        public float nota1;
        public float nota2;
        public float nota3;
        public float nota4;
        public float resultado;
        public string nome;
        public float maiornota;
        public float menornota;

        public void MaiorNota ()
        {

        }

        public void MediaNota ()
        {
            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            if (resultado == 9)
            {
                MessageBox.Show("boa nota");

            }


        }

        public void MenorNota ()
        {

        }

    }
}
