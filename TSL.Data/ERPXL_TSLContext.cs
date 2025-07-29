using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ComarchBlock;

public partial class ERPXL_TSLContext : DbContext
{
    public ERPXL_TSLContext()
    {
    }

    public ERPXL_TSLContext(DbContextOptions<ERPXL_TSLContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TSLCOMARCHDB;Database=ERPXL_TSL;User Id=sa_tsl;Password=@nalizyGrudzien24@;TrustServerCertificate=True;Command Timeout=180;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__UserGrou__C9F2845717067007");

            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Group).HasMaxLength(50);
            entity.Property(e => e.WindowsUser).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
