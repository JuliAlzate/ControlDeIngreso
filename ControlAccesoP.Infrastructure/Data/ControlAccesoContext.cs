using ControlAccesoP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAccesoP.Infrastructure.Data
{
     public class ControlAccesoContext : DbContext
    {

        public ControlAccesoContext()
        {

        }
        public ControlAccesoContext(DbContextOptions<ControlAccesoContext> options)
          : base(options)
        {
        }

        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        //nuevo
        public DbSet<Area> Area { get; set; }
        //nuevo
        public DbSet<Rol> Rol { get; set; }
        //nuevo
        public DbSet<Usuario> Usuario { get; set; }
        //nuevo
        public DbSet<Persona> Persona { get; set; }
        //nuevo
        public DbSet<Estado> Estado { get; set; }
        //nuevo
        public DbSet<LogBulk> LogBulk { get; set; }
        //nuevo
        public DbSet<BulkPersona> BulkPersona { get; set; }
        //nuevo
        public DbSet<RegistroPersona> RegistroPersona { get; set; }
        //nuevo
        public DbSet<PersonaEstado> PersonaEstado { get; set; }
    }
}
