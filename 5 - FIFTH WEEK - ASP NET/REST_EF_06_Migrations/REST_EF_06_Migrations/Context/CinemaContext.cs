using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using REST_EF_06_Migrations.Models;

namespace REST_EF_06_Migrations.Context
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options) { }

        public DbSet<Film> Pellicole { get; set; }

        //eseguiamo l'override per aggiungere funzionalità ai nostri models
        // protected override void ConfigureConventions  => configura le convenzioni sulla creazione delle tabelle, come il nome in uppercase o simil
        // protected override void OnConfiguring  => viene invocato quando usiamo il dbcontex
        // protected override void OnModelCreating  => sizeof occupa della creazione del modello all'interno del db

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasIndex(film => film.Codice).IsUnique(); //il codice sarà l'indice di tutte le entità e sarà ovviamente unico
        }


    }
}
