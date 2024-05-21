﻿using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class CtPhieunhap
{
    public int SoPhieuNhap { get; set; }

    public int IdSach { get; set; }

    public int DonGia { get; set; }

    public int ThanhTien { get; set; }

    public int SoLuongNhap { get; set; }

    public virtual Sach IdSachNavigation { get; set; } = null!;

    public virtual Phieunhapsach SoPhieuNhapNavigation { get; set; } = null!;
}
