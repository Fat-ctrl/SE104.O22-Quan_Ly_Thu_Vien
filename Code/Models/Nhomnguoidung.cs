using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Nhomnguoidung
{
    public int Id { get; set; }

    public string? MaNhomNguoiDung { get; set; }

    public string TenNhomNguoiDung { get; set; } = null!;

    public virtual ICollection<Nguoidung> Nguoidungs { get; set; } = new List<Nguoidung>();

    public virtual ICollection<Chucnang> IdChucNangs { get; set; } = new List<Chucnang>();
}
