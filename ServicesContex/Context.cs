using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesContex
{
    public class Context : DbContext
    {
        public DbSet<PersonsEntity> Persons { get; set; }
        public DbSet<ServicesEntity> Services { get; set; }

        public DbSet<DetallesEntity> Detalles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Data Source=JUANDA;Initial Catalog=PersonServices;Integrated Security=True; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonsEntity>().HasData(
                new PersonsEntity { PersonaId = "123456789", Nombres = "Juan David" ,Apellidos = "Forero", Email = "Iotled@yopmail.com" ,Direccion ="Bogota"},
                new PersonsEntity { PersonaId = "765390123", Nombres = "Juan Carlos", Apellidos = "Ramirez", Email = "Iotled@yopmail.com", Direccion = "Bogota" }
                );
            modelBuilder.Entity<ServicesEntity>().HasData(
                new ServicesEntity { ServicioId = Guid.NewGuid(), NommbreServicio = "Telefonia ETB", FechaCreacion = DateTime.Now,DescripcionServicio ="Sin Descripcion"},
                new ServicesEntity { ServicioId = Guid.NewGuid(), NommbreServicio = "Telefonia Claro", FechaCreacion = DateTime.Now, DescripcionServicio = "Sin Descripcion" }
                );
        }
    }
}