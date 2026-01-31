using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantOrderSystem.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderSystem.DAL.Configurations
{
    public class MenuItemConfiguration: IEntityTypeConfiguration<MenuItem>
    {
       
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.ToTable("MenuItems");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(x => x.Name)
                   .IsUnique();  

            builder.Property(x => x.Price)
                   .IsRequired()
                   .HasPrecision(18, 2);

            builder.Property(x => x.Category)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasOne(x => x.Orderİtem)
            .WithMany()
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
