using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class CtBcluotmuontheotheloai
{
    public int IdBaoCao { get; set; }

    public int IdTheLoai { get; set; }

    public int SoLuotMuon { get; set; }

    public decimal? TiLe { get; set; }

    public virtual Bcluotmuontheotheloai IdBaoCaoNavigation { get; set; } = null!;

    public virtual Theloai IdTheLoaiNavigation { get; set; } = null!;
}
