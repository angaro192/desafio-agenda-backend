using Agenda.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agenda.DAL.Maps
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("contact");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.ContactName).HasColumnName("contact_name").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Favorite).HasColumnName("favorite").IsRequired();
            builder.Property(x => x.TypeContact).HasColumnName("type_contact").IsRequired();
            builder.HasOne(x => x.Pessoa)
                .WithOne(p => p.Contact)
                .HasForeignKey<Contact>(x => x.PessoaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            builder.Property(x => x.PessoaId).HasColumnName("pessoa_id").IsRequired();
        }
    }
}
