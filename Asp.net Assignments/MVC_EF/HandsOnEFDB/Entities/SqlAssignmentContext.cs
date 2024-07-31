using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEFDB.Entities;

public partial class SqlAssignmentContext : DbContext
{
    public SqlAssignmentContext()
    {
    }

    public SqlAssignmentContext(DbContextOptions<SqlAssignmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<WorksOn> WorksOns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=GOUTHAMS\\SQLEXPRESS;Initial Catalog=SQL_assignment;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptNo).HasName("PK__Departme__72A83D0B6A1E2E13");

            entity.ToTable("Department");

            entity.Property(e => e.DeptNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Dept_no");
            entity.Property(e => e.DeptName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Dept_name");
            entity.Property(e => e.Location)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("location");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK__Employee__129850FA94422230");

            entity.ToTable("Employee");

            entity.Property(e => e.EmpNo)
                .ValueGeneratedNever()
                .HasColumnName("emp_no");
            entity.Property(e => e.DeptNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Dept_no");
            entity.Property(e => e.EmpFname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("emp_fname");
            entity.Property(e => e.EmpLname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("emp_lname");

            entity.HasOne(d => d.DeptNoNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DeptNo)
                .HasConstraintName("FK__Employee__Dept_n__4BAC3F29");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Product__DD37D91AE7358A87");

            entity.ToTable("Product");

            entity.HasIndex(e => e.Pname, "UQ__Product__173BB01CC01B4F85").IsUnique();

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("pid");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectNo).HasName("PK__project__BC79D7FB527AE577");

            entity.ToTable("project");

            entity.Property(e => e.ProjectNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("project_no");
            entity.Property(e => e.ProjectNameabk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("project_nameabk");
        });

        modelBuilder.Entity<WorksOn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("works_on");

            entity.Property(e => e.EmpNo).HasColumnName("emp_no");
            entity.Property(e => e.EnterDate).HasColumnName("enter_date");
            entity.Property(e => e.Job)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProjectNo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("project_no");

            entity.HasOne(d => d.EmpNoNavigation).WithMany()
                .HasForeignKey(d => d.EmpNo)
                .HasConstraintName("FK__works_on__emp_no__4F7CD00D");

            entity.HasOne(d => d.ProjectNoNavigation).WithMany()
                .HasForeignKey(d => d.ProjectNo)
                .HasConstraintName("FK__works_on__projec__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
