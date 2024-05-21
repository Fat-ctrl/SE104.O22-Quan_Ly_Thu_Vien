using System;
using System.Collections.Generic;

namespace QLTV_Nhom13.Models;

public partial class Tuasach
{
    public int Id { get; set; }

    public string? MaTuaSach { get; set; }

    public string TenTuaSach { get; set; } = null!;

    public int IdTheLoai { get; set; }

    public int? DaAn { get; set; }

    public virtual Theloai IdTheLoaiNavigation { get; set; } = null!;

    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();

    public virtual ICollection<Tacgium> IdTacGia { get; set; } = new List<Tacgium>();
}
