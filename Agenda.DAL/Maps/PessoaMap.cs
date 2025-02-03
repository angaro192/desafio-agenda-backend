using Agenda.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.DAL.Maps
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Photo).HasColumnName("photo").HasMaxLength(100).IsRequired();
            builder.Property(x => x.TypePicture).HasColumnName("type_picture").IsRequired();
            builder.HasOne(x => x.Contact)
                   .WithOne(c => c.Pessoa)
                   .HasForeignKey<Contact>(c => c.PessoaId);
            builder.HasOne(x => x.Address).WithOne(a => a.Pessoa).HasForeignKey<Address>(a => a.PessoaId);
        }
    }
}
