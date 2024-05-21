using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Theloai
{
    public int Id { get; set; }

    public string? MaTheLoai { get; set; }

    public string TenTheLoai { get; set; } = null!;

    public virtual ICollection<CtBcluotmuontheotheloai> CtBcluotmuontheotheloais { get; set; } = new List<CtBcluotmuontheotheloai>();

    public virtual ICollection<Tuasach> Tuasaches { get; set; } = new List<Tuasach>();
}
