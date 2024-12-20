﻿using DB_lez06_task_edicola.Models;
using DB_lez06_task_edicola.Models.DAL;

namespace DB_lez06_task_edicola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Creare un sistema di gestione edicola.
            * In un'edicola sono presenti riviste e giocattoli.
            * Entrambi sono caratterizzati da un codice univoco (assegnato automaticamente all'inserimento nel DB) ed il prezzo.
            * 
            * Un gicattolo è caratterizzato almeno da:
            * - materiale
            * - età minima
            * 
            * La rivista è caratterizzata
            * - titolo
            * - casa editrice
            * 
            * Creare un sistema che si occupi di:
            * 1. Inserire riviste o giocattoli
            * 2. Stampare tutti i prodotti
            * 3. Stampare solo le riviste (con LINQ)
            * 4. Stampare solo i giocattoli (con LINQ)
            * 
            * 5. Conta tutti gli elementi (con LINQ)
            * 5. Cercare un elemento e stamparne i dettagli tramite il codice univoco.
            */

            GiocattoloDAO giocattolo = GiocattoloDAO.GetInstance();
            Console.WriteLine(giocattolo);


        }
    }
}
