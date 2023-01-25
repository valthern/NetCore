﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class GeneroConfig:IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasKey(prop => prop.Identificador);
            //modelBuilder.Entity<Genero>().Property(prop => prop.Nombre).HasColumnName("NombreGenero").HasMaxLength(150).IsRequired();
            builder.Property(prop => prop.Nombre).HasMaxLength(150).IsRequired();
            //modelBuilder.Entity<Genero>().ToTable(name: "TablaGeneros", schema: "Peliculas");
        }
    }
}
