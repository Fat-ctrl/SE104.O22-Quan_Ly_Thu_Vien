using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLTV_Nhom13.Models;

public partial class QltvContext : DbContext
{
    public QltvContext()
    {
    }

    public QltvContext(DbContextOptions<QltvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bcluotmuontheotheloai> Bcluotmuontheotheloais { get; set; }

    public virtual DbSet<Bcsachtratre> Bcsachtratres { get; set; }

    public virtual DbSet<Chucnang> Chucnangs { get; set; }

    public virtual DbSet<CtBcluotmuontheotheloai> CtBcluotmuontheotheloais { get; set; }

    public virtual DbSet<CtPhieunhap> CtPhieunhaps { get; set; }

    public virtual DbSet<Cuonsach> Cuonsaches { get; set; }

    public virtual DbSet<Docgium> Docgia { get; set; }

    public virtual DbSet<Loaidocgium> Loaidocgia { get; set; }

    public virtual DbSet<Nguoidung> Nguoidungs { get; set; }

    public virtual DbSet<Nhomnguoidung> Nhomnguoidungs { get; set; }

    public virtual DbSet<Phieumuontra> Phieumuontras { get; set; }

    public virtual DbSet<Phieunhapsach> Phieunhapsaches { get; set; }

    public virtual DbSet<Phieuthu> Phieuthus { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<Tacgium> Tacgia { get; set; }

    public virtual DbSet<Thamso> Thamsos { get; set; }

    public virtual DbSet<Theloai> Theloais { get; set; }

    public virtual DbSet<Tuasach> Tuasaches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
*/        => optionsBuilder.UseSqlServer("Server=THEBEAST\\SQLExpress;Database=QLTV;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bcluotmuontheotheloai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BCLUOTMU__3213E83F648CF5D0");

            entity.ToTable("BCLUOTMUONTHEOTHELOAI");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaBaoCao)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](10),('BCLM'+right('0'+CONVERT([char](2),[THANG]),(2)))+CONVERT([char](4),[NAM])))", true)
                .IsFixedLength();
        });

        modelBuilder.Entity<Bcsachtratre>(entity =>
        {
            entity.HasKey(e => new { e.Ngay, e.IdCuonSach }).HasName("PK__BCSACHTR__8F93DB29364527A4");

            entity.ToTable("BCSACHTRATRE");

            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.IdCuonSach).HasColumnName("idCuonSach");
            entity.Property(e => e.NgayMuon).HasColumnType("datetime");

            entity.HasOne(d => d.IdCuonSachNavigation).WithMany(p => p.Bcsachtratres)
                .HasForeignKey(d => d.IdCuonSach)
                .HasConstraintName("FK__BCSACHTRA__idCuo__76969D2E");
        });

        modelBuilder.Entity<Chucnang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHUCNANG__3213E83F0B94521D");

            entity.ToTable("CHUCNANG");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaChucNang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](5),'CN'+right('000'+CONVERT([varchar](3),[id]),(3))))", true)
                .IsFixedLength();
        });

        modelBuilder.Entity<CtBcluotmuontheotheloai>(entity =>
        {
            entity.HasKey(e => new { e.IdBaoCao, e.IdTheLoai }).HasName("PK__CT_BCLUO__816BEA6E1766C753");

            entity.ToTable("CT_BCLUOTMUONTHEOTHELOAI");

            entity.Property(e => e.IdBaoCao).HasColumnName("idBaoCao");
            entity.Property(e => e.IdTheLoai).HasColumnName("idTheLoai");
            entity.Property(e => e.TiLe)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(4, 2)");

            entity.HasOne(d => d.IdBaoCaoNavigation).WithMany(p => p.CtBcluotmuontheotheloais)
                .HasForeignKey(d => d.IdBaoCao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CT_BCLUOT__idBao__70DDC3D8");

            entity.HasOne(d => d.IdTheLoaiNavigation).WithMany(p => p.CtBcluotmuontheotheloais)
                .HasForeignKey(d => d.IdTheLoai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CT_BCLUOT__idThe__71D1E811");
        });

        modelBuilder.Entity<CtPhieunhap>(entity =>
        {
            entity.HasKey(e => new { e.SoPhieuNhap, e.IdSach }).HasName("PK__CT_PHIEU__56D67F6A54175BF5");

            entity.ToTable("CT_PHIEUNHAP");

            entity.Property(e => e.IdSach).HasColumnName("idSach");

            entity.HasOne(d => d.IdSachNavigation).WithMany(p => p.CtPhieunhaps)
                .HasForeignKey(d => d.IdSach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CT_PHIEUN__idSac__5DCAEF64");

            entity.HasOne(d => d.SoPhieuNhapNavigation).WithMany(p => p.CtPhieunhaps)
                .HasForeignKey(d => d.SoPhieuNhap)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CT_PHIEUN__SoPhi__5CD6CB2B");
        });

        modelBuilder.Entity<Cuonsach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUONSACH__3213E83FC30B8CCD");

            entity.ToTable("CUONSACH");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdSach).HasColumnName("idSach");
            entity.Property(e => e.MaCuonSach)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](6),'CS'+right('0000'+CONVERT([varchar](10),[id]),(4))))", true)
                .IsFixedLength();
            entity.Property(e => e.TinhTrang).HasDefaultValue(1);

            entity.HasOne(d => d.IdSachNavigation).WithMany(p => p.Cuonsaches)
                .HasForeignKey(d => d.IdSach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CUONSACH__idSach__60A75C0F");
        });

        modelBuilder.Entity<Docgium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DOCGIA__3214EC27A33473F6");

            entity.ToTable("DOCGIA");

            entity.HasIndex(e => e.IdNguoiDung, "UQ__DOCGIA__BE010FC81C423626").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.IdLoaiDocGia).HasColumnName("idLoaiDocGia");
            entity.Property(e => e.IdNguoiDung).HasColumnName("idNguoiDung");
            entity.Property(e => e.MaDocGia)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](6),'DG'+right('0000'+CONVERT([varchar](10),[ID]),(4))))", true)
                .IsFixedLength();
            entity.Property(e => e.NgayHetHan).HasColumnType("datetime");
            entity.Property(e => e.NgayLapThe).HasColumnType("datetime");
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");

            entity.HasOne(d => d.IdLoaiDocGiaNavigation).WithMany(p => p.Docgia)
                .HasForeignKey(d => d.IdLoaiDocGia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DOCGIA__idLoaiDo__5165187F");

            entity.HasOne(d => d.IdNguoiDungNavigation).WithOne(p => p.Docgium)
                .HasForeignKey<Docgium>(d => d.IdNguoiDung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DOCGIA__idNguoiD__534D60F1");
        });

        modelBuilder.Entity<Loaidocgium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOAIDOCG__3213E83FCEBCB25E");

            entity.ToTable("LOAIDOCGIA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaLoaiDocGia)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](6),'LDG'+right('000'+CONVERT([varchar](10),[ID]),(3))))", true)
                .IsFixedLength();
        });

        modelBuilder.Entity<Nguoidung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NGUOIDUN__3213E83F50382582");

            entity.ToTable("NGUOIDUNG");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NGUOIDUN__55F68FC041D3D216").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdNhomNguoiDung).HasColumnName("idNhomNguoiDung");
            entity.Property(e => e.MaNguoiDung)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](6),'ND'+right('000000'+CONVERT([varchar](4),[id]),(4))))", true)
                .IsFixedLength();
            entity.Property(e => e.MatKhau).IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNhomNguoiDungNavigation).WithMany(p => p.Nguoidungs)
                .HasForeignKey(d => d.IdNhomNguoiDung)
                .HasConstraintName("FK__NGUOIDUNG__idNho__403A8C7D");
        });

        modelBuilder.Entity<Nhomnguoidung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHOMNGUO__3213E83FF34BE607");

            entity.ToTable("NHOMNGUOIDUNG");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaNhomNguoiDung)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](6),'NND'+right('000'+CONVERT([varchar](5),[id]),(3))))", true)
                .IsFixedLength();

            entity.HasMany(d => d.IdChucNangs).WithMany(p => p.IdNhomNguoiDungs)
                .UsingEntity<Dictionary<string, object>>(
                    "Phanquyen",
                    r => r.HasOne<Chucnang>().WithMany()
                        .HasForeignKey("IdChucNang")
                        .HasConstraintName("FK__PHANQUYEN__idChu__3C69FB99"),
                    l => l.HasOne<Nhomnguoidung>().WithMany()
                        .HasForeignKey("IdNhomNguoiDung")
                        .HasConstraintName("FK__PHANQUYEN__idNho__3B75D760"),
                    j =>
                    {
                        j.HasKey("IdNhomNguoiDung", "IdChucNang").HasName("PK__PHANQUYE__421733D850D74BFA");
                        j.ToTable("PHANQUYEN");
                        j.IndexerProperty<int>("IdNhomNguoiDung").HasColumnName("idNhomNguoiDung");
                        j.IndexerProperty<int>("IdChucNang").HasColumnName("idChucNang");
                    });
        });

        modelBuilder.Entity<Phieumuontra>(entity =>
        {
            entity.HasKey(e => e.SoPhieuMuonTra).HasName("PK__PHIEUMUO__EF67FB6F63C4398D");

            entity.ToTable("PHIEUMUONTRA");

            entity.Property(e => e.HanTra).HasColumnType("datetime");
            entity.Property(e => e.IdCuonSach).HasColumnName("idCuonSach");
            entity.Property(e => e.IdDocGia).HasColumnName("idDocGia");
            entity.Property(e => e.NgayMuon).HasColumnType("datetime");
            entity.Property(e => e.NgayTra).HasColumnType("datetime");
            entity.Property(e => e.SoTienPhat).HasDefaultValue(0);

            entity.HasOne(d => d.IdCuonSachNavigation).WithMany(p => p.Phieumuontras)
                .HasForeignKey(d => d.IdCuonSach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PHIEUMUON__idCuo__66603565");

            entity.HasOne(d => d.IdDocGiaNavigation).WithMany(p => p.Phieumuontras)
                .HasForeignKey(d => d.IdDocGia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PHIEUMUON__idDoc__656C112C");
        });

        modelBuilder.Entity<Phieunhapsach>(entity =>
        {
            entity.HasKey(e => e.SoPhieuNhap).HasName("PK__PHIEUNHA__4A9C88C16C3C10A9");

            entity.ToTable("PHIEUNHAPSACH");

            entity.Property(e => e.NgayNhap).HasColumnType("datetime");
        });

        modelBuilder.Entity<Phieuthu>(entity =>
        {
            entity.HasKey(e => e.SoPhieuThu).HasName("PK__PHIEUTHU__6D06AEAB76238D5C");

            entity.ToTable("PHIEUTHU");

            entity.Property(e => e.IdDocGia).HasColumnName("idDocGia");
            entity.Property(e => e.NgayLap).HasColumnType("datetime");

            entity.HasOne(d => d.IdDocGiaNavigation).WithMany(p => p.Phieuthus)
                .HasForeignKey(d => d.IdDocGia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PHIEUTHU__idDocG__6A30C649");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SACH__3213E83FA0E9620F");

            entity.ToTable("SACH");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdTuaSach).HasColumnName("idTuaSach");
            entity.Property(e => e.MaSach)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](6),'S'+right('00000'+CONVERT([varchar](10),[id]),(5))))", true)
                .IsFixedLength();
            entity.Property(e => e.NamXb).HasColumnName("NamXB");
            entity.Property(e => e.NhaXb).HasColumnName("NhaXB");

            entity.HasOne(d => d.IdTuaSachNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.IdTuaSach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SACH__idTuaSach__5629CD9C");
        });

        modelBuilder.Entity<Tacgium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TACGIA__3213E83FF2FC550A");

            entity.ToTable("TACGIA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Matacgia)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](6),'TG'+right('0000'+CONVERT([varchar](10),[ID]),(4))))", true)
                .IsFixedLength()
                .HasColumnName("MATACGIA");

            entity.HasMany(d => d.IdTuaSaches).WithMany(p => p.IdTacGia)
                .UsingEntity<Dictionary<string, object>>(
                    "CtTacgium",
                    r => r.HasOne<Tuasach>().WithMany()
                        .HasForeignKey("IdTuaSach")
                        .HasConstraintName("FK__CT_TACGIA__idTua__4BAC3F29"),
                    l => l.HasOne<Tacgium>().WithMany()
                        .HasForeignKey("IdTacGia")
                        .HasConstraintName("FK__CT_TACGIA__idTac__4AB81AF0"),
                    j =>
                    {
                        j.HasKey("IdTacGia", "IdTuaSach").HasName("PK__CT_TACGI__0CEEA1FC1ED1A477");
                        j.ToTable("CT_TACGIA");
                        j.IndexerProperty<int>("IdTacGia").HasColumnName("idTacGia");
                        j.IndexerProperty<int>("IdTuaSach").HasColumnName("idTuaSach");
                    });
        });

        modelBuilder.Entity<Thamso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__THAMSO__3213E83FB97DC01D");

            entity.ToTable("THAMSO");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdQdkttienThu).HasColumnName("AD_QDKTTienThu");
        });

        modelBuilder.Entity<Theloai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__THELOAI__3213E83F040A560B");

            entity.ToTable("THELOAI");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaTheLoai)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](6),'TL'+right('0000'+CONVERT([varchar](4),[id]),(4))))", true)
                .IsFixedLength();
        });

        modelBuilder.Entity<Tuasach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TUASACH__3213E83F09F5F651");

            entity.ToTable("TUASACH");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DaAn).HasDefaultValue(0);
            entity.Property(e => e.IdTheLoai).HasColumnName("idTheLoai");
            entity.Property(e => e.MaTuaSach)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([char](6),'TS'+right('0000'+CONVERT([varchar](10),[ID]),(4))))", true)
                .IsFixedLength();

            entity.HasOne(d => d.IdTheLoaiNavigation).WithMany(p => p.Tuasaches)
                .HasForeignKey(d => d.IdTheLoai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TUASACH__idTheLo__44FF419A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
