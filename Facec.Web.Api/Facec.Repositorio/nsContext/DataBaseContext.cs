using Facec.Dominio.nsEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Repositorio.nsContext
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(){ }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
             
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
