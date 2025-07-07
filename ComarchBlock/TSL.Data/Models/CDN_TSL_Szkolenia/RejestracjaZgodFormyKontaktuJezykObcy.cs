using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class RejestracjaZgodFormyKontaktuJezykObcy
{
    public int RzfkjRzfkjid { get; set; }

    public int RzfkjRzfkid { get; set; }

    public short RzfkjJezykId { get; set; }

    public string RzfkjNazwa { get; set; } = null!;

    public virtual RejestracjaZgodFormyKontaktu RzfkjRzfk { get; set; } = null!;
}
