using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class OsoKompetencje
{
    public int OsKId { get; set; }

    public byte? OsKRodzaj { get; set; }

    public int? OsKOsoNumer { get; set; }

    public int? OsKKslid { get; set; }

    public int? OsKIdUprawnienia { get; set; }

    public string? OsKNazwa { get; set; }

    public int? OsKDataOd { get; set; }

    public int? OsKDataDo { get; set; }

    public int? OsKTermin { get; set; }

    public int? OsKStopienZnajomosci { get; set; }

    public int? OsKZakres { get; set; }

    public byte? OsKWymagane { get; set; }

    public byte? OsKUkonczone { get; set; }

    public byte? OsKSkierowany { get; set; }

    public string? OsKNabyteUpr { get; set; }

    public string? OsKNumerObcy { get; set; }

    public int? OsKOpeWnumer { get; set; }

    public int? OsKCzasWprowadzenia { get; set; }

    public int? OsKOpeMnumer { get; set; }

    public int? OsKCzasModyfikacji { get; set; }

    public virtual PrcKarty? OsKOsoNumerNavigation { get; set; }
}
