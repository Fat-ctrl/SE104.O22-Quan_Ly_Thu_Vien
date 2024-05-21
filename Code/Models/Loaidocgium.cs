using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Loaidocgium
{
    public int Id { get; set; }

    public string? MaLoaiDocGia { get; set; }

    public string TenLoaiDocGia { get; set; } = null!;

    public virtual ICollection<Docgium> Docgia { get; set; } = new List<Docgium>();
}
