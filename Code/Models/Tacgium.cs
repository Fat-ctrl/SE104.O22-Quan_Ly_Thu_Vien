using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Tacgium
{
    public int Id { get; set; }

    public string? Matacgia { get; set; }

    public string TenTacGia { get; set; } = null!;

    public virtual ICollection<Tuasach> IdTuaSaches { get; set; } = new List<Tuasach>();
}
