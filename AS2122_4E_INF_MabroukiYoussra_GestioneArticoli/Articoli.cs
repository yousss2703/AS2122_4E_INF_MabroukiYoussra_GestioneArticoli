using System;
using System.Collections.Generic;
using System.Text;

namespace AS2122_4E_INF_MabroukiYoussra_GestioneArticoli
{
    class Articoli
    {
        string codice;
        string descrizione;
        string unitaMisura;
        double prezzo;

        public Articoli(string codice, string descrizione, string unitaMisura, double prezzo)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitaMisura = unitaMisura;
            this.prezzo = prezzo;
        }

        public string Codice { get { return codice; } }
        public string Descrizione { get { return descrizione; } }
        public string UnitaMisura { get { return unitaMisura; } }
        public double Prezzo { get { return prezzo; } }
    }
}
