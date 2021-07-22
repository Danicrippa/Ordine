using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordine
{
    public class ordine
    {

        public int ID { get; set; }
        public string codiceCliente { get; set; }
        public decimal importoComplessivo { get; set; }
        public string[] prodottiAcquistati { get; set; }
        public Stato Stato { get; set; }
        public DateTime Creato { get; set; }

        public ordine()
        {
            Creato = DateTime.Now;
        }

        internal bool stampaDettagli()
        {
            throw new NotImplementedException();
        }
         public Stato AggiornaStato(Stato nuovoStato)
        {
            Stato = nuovoStato;
            return nuovoStato;
        }
        public void MostraOrdine()
        {

        }
        public void AggiungiOrdine()
        {

        }
    }
}
