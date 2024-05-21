using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Docgium
{
    public int Id { get; set; }

    public string? MaDocGia { get; set; }

    public string TenDocGia { get; set; } = null!;

    public DateTime NgaySinh { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public DateTime NgayLapThe { get; set; }

    public DateTime NgayHetHan { get; set; }

    public int IdLoaiDocGia { get; set; }

    public int TongNoHienTai { get; set; }

    public int IdNguoiDung { get; set; }

    public virtual Loaidocgium IdLoaiDocGiaNavigation { get; set; } = null!;

    public virtual Nguoidung IdNguoiDungNavigation { get; set; } = null!;

    public virtual ICollection<Phieumuontra> Phieumuontras { get; set; } = new List<Phieumuontra>();

    public virtual ICollection<Phieuthu> Phieuthus { get; set; } = new List<Phieuthu>();
}
