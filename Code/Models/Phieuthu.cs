using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Phieuthu
{
    public int SoPhieuThu { get; set; }

    public int IdDocGia { get; set; }

    public int SoTienThu { get; set; }

    public DateTime NgayLap { get; set; }

    public virtual Docgium IdDocGiaNavigation { get; set; } = null!;
}
