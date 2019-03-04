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
            if (nota1 >= nota2 & nota1 >= nota3 & nota1 >= nota4)
            {
                maiornota = nota1;

            }
            if (nota2 >= nota1 && nota2 >= nota3 && nota2 >= nota4)
            {
                maiornota = nota2;

            }
            if (nota3 >= nota1 && nota3 >= nota2 && nota3 >= nota4)
            {
                maiornota = nota3;

            }
         
            if (nota4 >= nota1 && nota4 >= nota2 && nota4 >= nota3)
            {
                maiornota = nota4;
            }

        }

        public void MediaNota ()
        {
            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            if (resultado == 10)
            {
                MessageBox.Show("Nota maxima");

            }


        }

        public void MenorNota ()
        {
            if (nota1 <= nota2 && nota1 <= nota3 && nota1 <= nota4)
            {
                menornota= nota1;

            }
            if (nota2 <= nota1 && nota2 <= nota3 && nota2 <= nota4)
            {
                menornota = nota2;

            }
            if (nota3  <= nota2 && nota3 <= nota1 && nota3 <= nota4)
            {
                menornota = nota3;

            }

            if (nota4 <= nota1 && nota4 <= nota2 && nota4 <= nota3)
            {
                menornota = nota4;
            }

        }

    }
}
