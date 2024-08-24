using Dima.core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dima.Api.Data.Mappings;

public class TransactionMapping : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transactions");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Titulo)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);
            
        builder.Property(x => x.Type)
            .IsRequired()
            .HasColumnType("SMALLINT");
            
        builder.Property(x => x.Amount)
            .IsRequired()  
            .HasColumnType("DECIMAL(18,2)"); 
            
        builder.Property(x => x.CreatedAt)
            .IsRequired();
            
        builder.Property(x => x.PaidOrReceivedAt)
            .IsRequired(false);
            
        builder.Property(x => x.UserId)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(160);
    }
}

