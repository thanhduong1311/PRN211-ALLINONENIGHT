using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.Models;

public partial class PetShopProjectContext : DbContext
{
    public PetShopProjectContext()
    {
    }

    public PetShopProjectContext(DbContextOptions<PetShopProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MemberOrder> MemberOrders { get; set; }

    public virtual DbSet<Pet> Pets { get; set; }

    public virtual DbSet<PetGroup> PetGroups { get; set; }

    public virtual DbSet<PetShopMember> PetShopMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-S71BQS34\\DUONGNT;User ID=sa;Password=1;Database=PetShopProject;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MemberOrder>(entity =>
        {
            entity.ToTable("MemberOrder");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MemberId).HasMaxLength(20);

            entity.HasOne(d => d.Member).WithMany(p => p.MemberOrders)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberOrder_PetShopMember");

            entity.HasOne(d => d.Pet).WithMany(p => p.MemberOrders)
                .HasForeignKey(d => d.PetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberOrder_Pet");
        });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.PetId).HasName("PK__Pet__48E53862D6D4D206");

            entity.ToTable("Pet");

            entity.Property(e => e.PetId).ValueGeneratedNever();
            entity.Property(e => e.ImportDate).HasColumnType("datetime");
            entity.Property(e => e.PetDescription).HasMaxLength(220);
            entity.Property(e => e.PetGroupId).HasMaxLength(20);
            entity.Property(e => e.PetName).HasMaxLength(200);

            entity.HasOne(d => d.PetGroup).WithMany(p => p.Pets)
                .HasForeignKey(d => d.PetGroupId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Pet__PetGroupId__52593CB8");
        });

        modelBuilder.Entity<PetGroup>(entity =>
        {
            entity.HasKey(e => e.PetGroupId).HasName("PK__PetGroup__2C661F9840113DCB");

            entity.ToTable("PetGroup");

            entity.Property(e => e.PetGroupId).HasMaxLength(20);
            entity.Property(e => e.GroupDescription).HasMaxLength(150);
            entity.Property(e => e.OriginalSource).HasMaxLength(60);
            entity.Property(e => e.PetGroupName).HasMaxLength(80);
        });

        modelBuilder.Entity<PetShopMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__PetShopM__0CF04B38738DDAF7");

            entity.ToTable("PetShopMember");

            entity.HasIndex(e => e.EmailAddress, "UQ__PetShopM__49A147401BF9DF9A").IsUnique();

            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .HasColumnName("MemberID");
            entity.Property(e => e.EmailAddress).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(80);
            entity.Property(e => e.MemberPassword).HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
