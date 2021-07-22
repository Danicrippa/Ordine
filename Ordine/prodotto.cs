using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordine
{
    class prodotto
    {
        public int ID { get; set; }
        public string codiceProdotto { get; set; }
        public decimal Prezzo { get; set; }
        public string[] descrizione { get; set; }
        
    }
}
