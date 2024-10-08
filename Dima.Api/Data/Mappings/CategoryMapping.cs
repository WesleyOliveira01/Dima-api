using Dima.core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dima.Api.Data.Mappings;

public class CategoryMapping : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.Titulo)
            .IsRequired()
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);
            
        builder
            .Property(x => x.Description)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);
            
        builder
            .Property(x => x.UserId)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(160);
    }
}

