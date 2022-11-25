using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1.DAL.DomainClass;

#nullable disable

namespace _1.DAL.Context
{
    public partial class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {
        }

        public FpolyDBContext(DbContextOptions<FpolyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anh> Anhs { get; set; }
        public virtual DbSet<ChatLieu> ChatLieus { get; set; }
        public virtual DbSet<ChiTietKieuSp> ChiTietKieuSps { get; set; }
        public virtual DbSet<ChiTietSale> ChiTietSales { get; set; }
        public virtual DbSet<ChiTietSp> ChiTietSps { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<CttichDiem> CttichDiems { get; set; }
        public virtual DbSet<GiaiDau> GiaiDaus { get; set; }
        public virtual DbSet<HinhThucMh> HinhThucMhs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KichCo> KichCos { get; set; }
        public virtual DbSet<KieuSp> KieuSps { get; set; }
        public virtual DbSet<LstichDiem> LstichDiems { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PtthanhToan> PtthanhToans { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TichDiem> TichDiems { get; set; }
        public virtual DbSet<UdtichDiem> UdtichDiems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

                optionsBuilder.UseSqlServer("Data Source=NUGETRENKI\\SQLEXPRESS;Initial Catalog=PRO131_GROUP3;Persist Security Info=True;User ID=nugetrenki;Password=11223344");


            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Anh>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.Anhs)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .HasConstraintName("FK9");
            });

            modelBuilder.Entity<ChatLieu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ChiTietKieuSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.ChiTietKieuSps)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .HasConstraintName("FK__ChiTietKi__IdChi__55F4C372");

                entity.HasOne(d => d.IdKieuSpNavigation)
                    .WithMany(p => p.ChiTietKieuSps)
                    .HasForeignKey(d => d.IdKieuSp)
                    .HasConstraintName("FK__ChiTietKi__IdKie__55009F39");
            });

            modelBuilder.Entity<ChiTietSale>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.ChiTietSales)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .HasConstraintName("FK__ChiTietSa__IdChi__540C7B00");

                entity.HasOne(d => d.IdSaleNavigation)
                    .WithMany(p => p.ChiTietSales)
                    .HasForeignKey(d => d.IdSale)
                    .HasConstraintName("FK__ChiTietSa__IdSal__531856C7");
            });

            modelBuilder.Entity<ChiTietSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaQr).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThaiKhuyenMai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChatLieuNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdChatLieu)
                    .HasConstraintName("FK__ChiTietSP__IdCha__51300E55");

                entity.HasOne(d => d.IdKichCoNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdKichCo)
                    .HasConstraintName("FK__ChiTietSP__IdKic__4F47C5E3");

                entity.HasOne(d => d.IdMauSacNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdMauSac)
                    .HasConstraintName("FK__ChiTietSP__IdMau__4E53A1AA");

                entity.HasOne(d => d.IdSpNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdSp)
                    .HasConstraintName("FK__ChiTietSP__IdSP__4D5F7D71");

                entity.HasOne(d => d.IdTeamNavigation)
                    .WithMany(p => p.ChiTietSps)
                    .HasForeignKey(d => d.IdTeam)
                    .HasConstraintName("FK__ChiTietSP__IdTea__503BEA1C");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CttichDiem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GiaiDau>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HinhThucMh>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cod).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiamGia).HasDefaultValueSql("((0))");

                entity.Property(e => e.HinhThucGiamGia).IsUnicode(false);

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.SoTienGiam).HasDefaultValueSql("((0))");

                entity.Property(e => e.TienChuyenKhoan).HasDefaultValueSql("((0))");

                entity.Property(e => e.TienKhachDua).HasDefaultValueSql("((0))");

                entity.Property(e => e.TienShip).HasDefaultValueSql("((0))");

                entity.Property(e => e.TongTien).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThaiGiaoHang).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdHtNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdHt)
                    .HasConstraintName("FK__HoaDon__IdHT__4C6B5938");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__HoaDon__IdKH__498EEC8D");

                entity.HasOne(d => d.IdNvNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNv)
                    .HasConstraintName("FK__HoaDon__IdNV__4A8310C6");

                entity.HasOne(d => d.IdPtttNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdPttt)
                    .HasConstraintName("FK__HoaDon__IdPTTT__4B7734FF");

                entity.HasOne(d => d.IdUdtichDiemNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdUdtichDiem)
                    .HasConstraintName("FK__HoaDon__IdUDTich__56E8E7AB");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChiTietSpNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdChiTietSp)
                    .HasConstraintName("FK2");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoaDon)
                    .HasConstraintName("FK1");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdnvNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.Idnv)
                    .HasConstraintName("FK__KhachHang__IDNV__58D1301D");

                entity.HasOne(d => d.IdtichDiemNavigation)
                    .WithMany(p => p.KhachHangs)
                    .HasForeignKey(d => d.IdtichDiem)
                    .HasConstraintName("FK__KhachHang__IDTic__57DD0BE4");
            });

            modelBuilder.Entity<KichCo>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cm).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.Size).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KieuSp>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdChaNavigation)
                    .WithMany(p => p.InverseIdChaNavigation)
                    .HasForeignKey(d => d.IdCha)
                    .HasConstraintName("FK11");
            });

            modelBuilder.Entity<LstichDiem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.SoDiemDung).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCttichDiemNavigation)
                    .WithMany(p => p.LstichDiems)
                    .HasForeignKey(d => d.IdCttichDiem)
                    .HasConstraintName("FK8");

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.LstichDiems)
                    .HasForeignKey(d => d.IdHoaDon)
                    .HasConstraintName("FK5");

                entity.HasOne(d => d.IdTichDiemNavigation)
                    .WithMany(p => p.LstichDiems)
                    .HasForeignKey(d => d.IdTichDiem)
                    .HasConstraintName("FK7");
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cccd).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.Property(e => e.TaiKhoan).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCvNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdCv)
                    .HasConstraintName("FK__NhanVien__IdCV__489AC854");
            });

            modelBuilder.Entity<PtthanhToan>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MucGiam).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdGdNavigation)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.IdGd)
                    .HasConstraintName("FK__Team__IdGD__5224328E");
            });

            modelBuilder.Entity<TichDiem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UdtichDiem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ma).IsUnicode(false);

                entity.Property(e => e.MucUuDai).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoDiem).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
