using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Chucnang
{
    public int Id { get; set; }

    public string? MaChucNang { get; set; }

    public string TenChucNang { get; set; } = null!;

    public string TenManHinh { get; set; } = null!;

    public virtual ICollection<Nhomnguoidung> IdNhomNguoiDungs { get; set; } = new List<Nhomnguoidung>();
}
