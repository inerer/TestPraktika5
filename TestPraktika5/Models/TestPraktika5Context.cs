using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestPraktika5.Models;

public partial class TestPraktika5Context : DbContext
{
    public TestPraktika5Context()
    {
    }

    public TestPraktika5Context(DbContextOptions<TestPraktika5Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TableMain> TableMains { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DANILAPC\\SQLEXPRESS;Database=TestPraktika5;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TableMain>(entity =>
        {
            entity.HasKey(e => e.TableMainId).HasName("PK__Table_ma__051F763C21BE4A1F");

            entity.ToTable("Table_main");

            entity.Property(e => e.TableMainId).HasColumnName("table_main_id");
            entity.Property(e => e.Day1)
                .HasMaxLength(50)
                .HasColumnName("day1");
            entity.Property(e => e.Day2)
                .HasMaxLength(50)
                .HasColumnName("day2");
            entity.Property(e => e.Day3)
                .HasMaxLength(50)
                .HasColumnName("day3");
            entity.Property(e => e.Day4)
                .HasMaxLength(50)
                .HasColumnName("day4");
            entity.Property(e => e.Day5)
                .HasMaxLength(50)
                .HasColumnName("day5");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("middle_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
