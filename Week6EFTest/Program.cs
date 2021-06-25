using System;

namespace Week6EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //modello E-R DONE
            //modello con classi DONE
            //context DONE
            //fluent api o data annotation DONE

            //DB (con migration) DONE
            //repository DONE
            //menu
            //-Inserire nuovi clienti 
            //-Inserire una polizza(rcauto, furto, vita) per un client
            //- Stampare i dati delle polizze presenti
            //a db(comprese le info sul cliente che l'ha stipulata*) CREATE/GET ALL
            //* In fase di stampa dei dati del cliente
            //deve essere visualizzabile anche la spesa totale
            //mensile che il cliente sostiene per tutte le sue polizze.


            //Requisiti tecnici:
            //Utilizzare le Migration di EF per la modifica del DB DONE
            //Utilizzare le Fluent Api per la gestione dei requisiti del database DONE
            //Realizzare un menù per l’interazione con l’utente

            bool goon = true;
            while (goon)
            {
                goon = InsuranceManager.Menu();
            }
        }
    }
}
