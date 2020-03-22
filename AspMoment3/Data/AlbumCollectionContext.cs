using AspMoment3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMoment3.Data
{
    public class AlbumCollectionContext : DbContext //Ärver från DbContext-klassen
    {
        //Konstruktor med inställningar till databasen.
        public AlbumCollectionContext(DbContextOptions<AlbumCollectionContext> options):base(options)
        {
        }
        //Db-set på modellerna, blir databasens tabeller.
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

    }
}
