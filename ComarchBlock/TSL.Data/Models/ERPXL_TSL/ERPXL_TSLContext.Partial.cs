using ComarchBlock.entities;
using Microsoft.EntityFrameworkCore;

namespace TSL.Data.Models.ERPXL_TSL
{
    public partial class ERPXL_TSLContext
    {
        public virtual DbSet<DbUserGroup> UserGroupsDb { get; set; }
        public virtual DbSet<DbModuleLimit> ModuleLimitsDb { get; set; }
        public virtual DbSet<DbGroupModuleLimit> GroupModuleLimitsDb { get; set; }
        public virtual DbSet<DbLinkedModule> LinkedModulesDb { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbUserGroup>(entity =>
            {
                entity.ToTable("UserGroups");
                entity.HasKey(e => e.UserName);
                entity.Property(e => e.UserName).HasColumnName("UserName");
                entity.Property(e => e.Group).HasColumnName("Group");
                entity.Property(e => e.WindowsUser).HasColumnName("WindowsUser");
            });

            modelBuilder.Entity<DbModuleLimit>(entity =>
            {
                entity.ToTable("ModuleLimits");
                entity.HasKey(e => e.Module);
                entity.Property(e => e.Module).HasColumnName("Module");
                entity.Property(e => e.MaxLicenses).HasColumnName("MaxLicenses");
            });

            modelBuilder.Entity<DbGroupModuleLimit>(entity =>
            {
                entity.ToTable("GroupModuleLimits");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.GroupCode).HasColumnName("GroupCode");
                entity.Property(e => e.Module).HasColumnName("Module");
                entity.Property(e => e.Hour).HasColumnName("Hour");
                entity.Property(e => e.MaxLicenses).HasColumnName("MaxLicenses");
            });

            modelBuilder.Entity<DbLinkedModule>(entity =>
            {
                entity.ToTable("LinkedModules");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ModuleKey).HasColumnName("ModuleKey");
                entity.Property(e => e.LinkedModule).HasColumnName("LinkedModule");
            });
        }
    }
}
