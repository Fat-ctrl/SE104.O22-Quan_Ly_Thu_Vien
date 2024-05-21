using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Bcluotmuontheotheloai
{
    public int Id { get; set; }

    public int Thang { get; set; }

    public int Nam { get; set; }

    public string? MaBaoCao { get; set; }

    public int TongSoLuotMuon { get; set; }

    public virtual ICollection<CtBcluotmuontheotheloai> CtBcluotmuontheotheloais { get; set; } = new List<CtBcluotmuontheotheloai>();
}
