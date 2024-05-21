﻿using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Phieumuontra
{
    public int SoPhieuMuonTra { get; set; }

    public int IdDocGia { get; set; }

    public int IdCuonSach { get; set; }

    public DateTime NgayMuon { get; set; }

    public DateTime? NgayTra { get; set; }

    public DateTime HanTra { get; set; }

    public int? SoTienPhat { get; set; }

    public virtual Cuonsach IdCuonSachNavigation { get; set; } = null!;

    public virtual Docgium IdDocGiaNavigation { get; set; } = null!;
}
