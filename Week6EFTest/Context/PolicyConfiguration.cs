using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week6EFTest.Models;

namespace Week6EFTest.Context
{
    internal class PolicyConfiguration : IEntityTypeConfiguration<Policy>
    {
        public void Configure(EntityTypeBuilder<Policy> builder)
        {
            builder.ToTable("Policy");
            builder.HasKey(k => k.NUM);
            builder.Property("NUM").IsFixedLength().HasMaxLength(10);
            builder.Property("Date").HasColumnType("datetime").IsRequired();
            builder.Property("Amount").HasColumnType("float").IsRequired();
            builder.Property("MonthlyFee").HasColumnType("float").IsRequired();

            builder.HasOne(p => p.Client).WithMany(c => c.Policies).HasForeignKey(f => f.ClientCode);

            // gerarchia
            builder.HasDiscriminator<string>("prodotto_type")
                        .HasValue<Policy>("policy")
                        .HasValue<Furto>("furto")
                        .HasValue<Life>("life")
                        .HasValue<Auto>("auto");


            
        }

        
    }
}