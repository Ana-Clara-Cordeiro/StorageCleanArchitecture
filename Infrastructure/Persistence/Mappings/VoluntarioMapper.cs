using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Infrastructure.Persistence.Mappers
{
    public class VoluntarioMapper : IEntityTypeConfiguration<VoluntarioModel>
    {
        public void Configure(EntityTypeBuilder<VoluntarioModel> builder)
        {
            builder.ToTable("VOLUNTARIOS");

            builder.HasKey(v => v.Id);
            builder.Property(v => v.Id).HasColumnName("ID_VOLUNTARIO").IsRequired();
            builder.Property(v => v.Nome).HasColumnName("NOME_VOLUNTARIO").HasMaxLength(100).IsRequired();
            builder.Property(v => v.Telefone).HasColumnName("TELEFONE_VOLUNTARIO").HasMaxLength(20).IsRequired();
        }

    }
}
