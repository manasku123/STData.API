using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentData.Entity.Models;

public partial class StudentMasterContext : DbContext
{
    public StudentMasterContext()
    {
    }

    public StudentMasterContext(DbContextOptions<StudentMasterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    private DbSet<SheetMaster> sheetMasters;

    public virtual DbSet<SheetMaster> GetSheetMasters()
    {
        return sheetMasters;
    }

    public virtual void SetSheetMasters(DbSet<SheetMaster> value)
    {
        sheetMasters = value;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAPTOP-OOS7IVTU\\MANASSQLSERVER;Initial Catalog=StudentMaster;User Id=sa; password=root;Persist Security Info=False;Integrated Security=false;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SheetMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student");

            entity.Property(e => e.Mark)
                .ValueGeneratedOnAdd()
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student");

            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
