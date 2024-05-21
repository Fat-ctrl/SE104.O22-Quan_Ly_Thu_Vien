using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Cuonsach
{
    public int Id { get; set; }

    public string? MaCuonSach { get; set; }

    public int IdSach { get; set; }

    public int TinhTrang { get; set; }

    public int DaAn { get; set; }

    public virtual ICollection<Bcsachtratre> Bcsachtratres { get; set; } = new List<Bcsachtratre>();

    public virtual Sach IdSachNavigation { get; set; } = null!;

    public virtual ICollection<Phieumuontra> Phieumuontras { get; set; } = new List<Phieumuontra>();
}
