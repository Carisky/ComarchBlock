using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KartyKredytowe
{
    public int KkrKkrId { get; set; }

    public short KkrAlgorytm { get; set; }

    public string KkrNazwa { get; set; } = null!;

    public virtual ICollection<BnkRachunki> BnkRachunkis { get; set; } = new List<BnkRachunki>();

    public virtual ICollection<BnkZapisy> BnkZapisies { get; set; } = new List<BnkZapisy>();
}
