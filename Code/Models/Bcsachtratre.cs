﻿using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Bcsachtratre
{
    public DateTime Ngay { get; set; }

    public int IdCuonSach { get; set; }

    public DateTime NgayMuon { get; set; }

    public int SoNgayTre { get; set; }

    public virtual Cuonsach IdCuonSachNavigation { get; set; } = null!;
}
