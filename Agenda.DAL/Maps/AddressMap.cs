using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.DAL.Maps
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.ZipCode).HasColumnName("zip_code").HasMaxLength(8).IsRequired();
            builder.Property(x => x.City).HasColumnName("city").HasMaxLength(100).IsRequired();
            builder.Property(x => x.State).HasColumnName("state").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Country).HasColumnName("country").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Street).HasColumnName("street").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Neighborhood).HasColumnName("neighborhood").HasMaxLength(100).IsRequired();
            builder.HasOne(x => x.Pessoa)
                .WithOne(p => p.Address)
                .HasForeignKey<Address>(x => x.PessoaId);
            builder.Property(x => x.PessoaId).HasColumnName("pessoa_id").IsRequired();

        }
    }
}
