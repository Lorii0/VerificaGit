using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGit
{
    internal class Libro
    {
        string autore;
        string titolo;
        int annoPubblicazione;
        string editore;
        int nPagine;

        public string Autore { get { return autore; }set { autore = value; } }
        public string Titolo { get { return autore; } set { autore = value; } }
        public int AnnoPubblicazione { get { return annoPubblicazione; } set { annoPubblicazione = value; } }
        public string Editore { get { return editore; } set { editore = value; } }
        public int NumeroPagine { get { return nPagine; } set { nPagine = value; } }


        Libro(string autore, string titolo, int annoPubblicazione, string editore, int nPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.annoPubblicazione = annoPubblicazione;
            this.editore = editore;
            this.nPagine = nPagine;
        }

        public string ToString()
        {
            return $"autore:{autore} titolo:{titolo} anno pubblicazione:{annoPubblicazione.ToString()} editore:{editore} numero pagine:{nPagine}";
        }

        public string readingTime()
        {
            string res="";

            if (nPagine < 100) res = "1h di lettura";
            else if (nPagine > 100 && nPagine < 200) res = "2h di lettura";
            else res = "più di 2h di lettura";

            return res;
        }
    }
}
