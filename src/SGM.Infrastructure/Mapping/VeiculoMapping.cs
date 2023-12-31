﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM.Infrastructure.Mapping
{
    public  class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder) 
        {
            builder.ToTable("Veiculo");
            builder.HasKey(x => x.VeiculoId);
            builder.Property(x => x.VeiculoId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.MarcaId);
            builder.Property(x => x.Modelo);
            builder.Property(x => x.VeiculoAtivo);
            builder.Property(x => x.DataCadastro);
        }
    }
}
