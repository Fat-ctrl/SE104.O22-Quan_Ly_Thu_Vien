using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Phieunhapsach
{
    public int SoPhieuNhap { get; set; }

    public int TongTien { get; set; }

    public DateTime NgayNhap { get; set; }

    public virtual ICollection<CtPhieunhap> CtPhieunhaps { get; set; } = new List<CtPhieunhap>();
}
