using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class CechyKlasy
{
    public short? CckGidtyp { get; set; }

    public int? CckGidfirma { get; set; }

    public int CckGidnumer { get; set; }

    public short? CckGidlp { get; set; }

    public string? CckNazwa { get; set; }

    public byte? CckZlisty { get; set; }

    public string? CckOpis { get; set; }

    public byte? CckZamknieta { get; set; }

    public int? CckCzasModyfikacji { get; set; }

    public virtual ICollection<Cechy> Cechies { get; set; } = new List<Cechy>();
}
