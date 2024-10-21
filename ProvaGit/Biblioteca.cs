using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGit
{
    internal class Biblioteca
    {
        public List<Libro> libri = new List<Libro>();

        string nome;
        

        string indirizzo;
        string apertura;    //orario 
        string chiusura;    //orario

        public string Nome { get { return nome; }set { nome = value; } }
        public string Indirizzo { get { return indirizzo; } set { indirizzo = value; } }

        public string Apertura { get { return apertura; } set { apertura = value; } }

        public string Chiusura { get { return chiusura; } set { chiusura = value; } }


        Biblioteca(string nome, string indirizzo, string apertura, string chiusura) {
            this.nome = nome;
            this.apertura = apertura;
            this.chiusura = chiusura;
            this.indirizzo = indirizzo;
        }

        public void Add(Libro libro)
        {
            libri.Add(libro);
        }

        public Libro RicercaLibro(string titolo)    //ritorna libro singolo
        {
            for (int i = 0; i < libri.Count; i++)
            {
                if (libri[i].Titolo == titolo) return libri[i]; 
            }
            throw new Exception();
        }

        public List<Libro> RicercaLibriAutore(string autore)    //ritorna lista di libri
        {
            List<Libro> l = new List<Libro>();
            for (int i = 0; i < libri.Count; i++)
            {
                if (libri[i].Autore == autore)
                {
                    l.Add(libri[i]);
                }
            }
            return l;
        }

        public int NumeroLibri()
        {
            return libri.Count;
        }




    }
}
