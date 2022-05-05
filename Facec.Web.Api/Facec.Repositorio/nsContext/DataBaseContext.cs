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
            modelBuilder.Entity<Cliente>(x =>
            {
                x.ToTable("CLIENTE");
                x.Property(y => y.Id).HasColumnName("ID");
                x.Property(y => y.Documento).HasColumnName("DS_DOCUMENTO").IsRequired();
                x.Property(y => y.Nome).HasColumnName("DS_NOME");


            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
