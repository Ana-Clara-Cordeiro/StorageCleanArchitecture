using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storage.Domain.Entities;

namespace Storage.Infrastructure.Persistence.Mappings
{
    internal class ChavesMapper : IEntityTypeConfiguration<ChavesModel>
    {
        public void Configure(EntityTypeBuilder<ChavesModel> builder)
        {
            builder.ToTable("CHAVE");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("ID_CHAVE").IsRequired().ValueGeneratedOnAdd();
            builder.Property(c => c.Nome).HasColumnName("NOME_CHAVE").HasMaxLength(100).IsRequired();
            builder.Property(c => c.Descricao).HasColumnName("DESCRICAO_CHAVE").HasMaxLength(100).IsRequired();
            builder.Property(c => c.Quantidade).HasColumnName("QTDE_COPIAS_CHAVE").IsRequired();
        }
        
    }
}
