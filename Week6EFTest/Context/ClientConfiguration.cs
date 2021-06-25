using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week6EFTest.Models;

namespace Week6EFTest.Context
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(k => k.CF);
            builder.Property("CF").HasMaxLength(16).HasColumnType("int");
            builder.Property("Name").HasMaxLength(20).IsRequired();
            builder.Property("Lastname").HasMaxLength(20).IsRequired();
            builder.Property("Address").HasMaxLength(50).IsRequired();
        }
    }
}