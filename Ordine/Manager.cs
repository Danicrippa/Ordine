using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordine
{
    internal class Manager
    {
        public static List<prodotto> Prodotto = new List<prodotto>();

        
        public static List<ordine> Ordini = new List<ordine>();

        public static void MostraOrdini()
        {
            foreach (ordine o in Ordini)
            {
                Console.WriteLine(o.stampaDettagli());
            }
        }
        public static void AggiungiOrdine()
        {
            int i = 0;
            int a = 0;

            do
            {
                ordine o = new Ordine();
                Console.WriteLine($"Ordine {i + 1}");

                Console.WriteLine("inserisci ID ");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("errore, riprova");
                }
                o.ID = id;

                Console.WriteLine("inserisci codice cliente");
                o.codiceCliente = Console.ReadLine();

                Console.WriteLine("inserisci importo complessivo");
                o.importoComplessivo = decimal.Parse(Console.ReadLine());

                int a ();
                int j = 0;
                List<string> prodotti = new List<string>();
            } ;
            
            

        //public static string Menu(string title, List<string> menuItems)
        //{
        //    Console.Clear();
        //    Console.WriteLine($"============= {title} =============");
        //    Console.WriteLine();

        //    foreach (var item in menuItems)
        //    {
        //        Console.WriteLine(item);
        //        Console.WriteLine();
        //    }

        //    // get command
        //    Console.Write("> ");
        //    string command = Console.ReadLine();
        //    Console.WriteLine();

        //    return command;
        //}

        //public static void Ordine(ordine[] list)
        //{
        //    Console.Clear();
        //    Console.WriteLine("{0,-10}{1,-60}{2,-20}{3,-10}", "ID", "Codice Cliente", "Stato", "Importo");
        //    Console.WriteLine(new String('-', 100));
        //    foreach (var item in list)
        //    {
        //        if (item != null)
        //            Console.WriteLine($"{item.ID,-10}{item.codiceCliente,-60}{item.Stato,-20}{item.importoComplessivo,-10}");
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine(">> Premi un tasto per tornare al menu");
        //    Console.ReadKey();
        //}


        //public static string GetData(string message)
        //{
        //    Console.Write(message + ": ");
        //    var value = Console.ReadLine();
        //    return value;
        //}

        //public static string GetData(string message, string initialValue)
        //{
        //    Console.Write(message + $" ({initialValue}): ");
        //    var value = Console.ReadLine();
        //    return string.IsNullOrEmpty(value) ? initialValue : value;
        //}


        //public static T GetEnum<T>(T state) where T : struct
        //{
        //    string enumLegenda = $"Stato ({state}) [";
        //    foreach (var suit in Enum.GetValues(typeof(T)))
        //    {
        //        enumLegenda += suit.ToString() + "/";
        //    }
        //    enumLegenda += "] > ";

        //    Console.Write(enumLegenda);
        //    var value = Console.ReadLine();

        //    Enum.TryParse<T>(value, true, out T result);

        //    return result;
        }



    }
}
