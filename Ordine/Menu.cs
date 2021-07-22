using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordine
{
    class Menu
    {
        internal static void Start()
        {
            int scelta = 0;
            int MostraOrdine = 0;
            int AggiungiOrdine = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("premi 1 per visualizzare gli ordini");
                Console.WriteLine("premi 2 per inserire una nuova ordine");
                Console.WriteLine("premi 0 per uscire");

             while (int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 2)
             {
                    Console.WriteLine("Error");
             }

             switch (scelta)
             {
                    case 1:
                        ordine.MostraOrdine(ref);
                        break;
                    case 2:
                        ordine.AggiungiOrdine(ref);
                        break;
                    case 0:
                        Console.WriteLine("finito");
                        break;
             }

            } while (scelta != 0);
            {
                Console.WriteLine("errore");
            }
        }
    }
}


//        public static void MenuCliente()
//        {


//            bool quit = false;

//            do
//            {
//                string command 
//                    new List<string> {
//                        "[ 1 ] - Lista Ordini",
//                        "[ 2 ] - Nuovo Ordine",
//                        "[ q ] - ESCI"
//                    });

//                switch (command)
//                {
//                    case "1":
//                        // gestione letterine

//                        ConsoleHelpers.BuildOrdineTable(Data.Ordini);
//                        break;
//                    case "2":
//                        // gestione magazzino

//                        Ordine newOrder = ClientForm.NewOrdineForm();
//                        if (newOrder != null)
//                            Data.Add(newOrder);
//                        break;
//                    case "q":
//                        quit = true;
//                        break;
//                    default:
//                        Console.WriteLine("Comando sconosciuto.");
//                        break;
//                }

//            } while (!quit);


//        }
//    }
//}


