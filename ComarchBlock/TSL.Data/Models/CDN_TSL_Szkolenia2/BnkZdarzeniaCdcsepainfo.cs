using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class BnkZdarzeniaCdcsepainfo
{
    public int BzdCsiBzdCsiid { get; set; }

    public int BzdCsiBzdId { get; set; }

    public byte BzdCsiSekcja { get; set; }

    public byte BzdCsiOsobaTyp { get; set; }

    public string BzdCsiNazwa { get; set; } = null!;

    public string BzdCsiBicbei { get; set; } = null!;

    public string BzdCsiIdent { get; set; } = null!;

    public string BzdCsiIdentTyp { get; set; } = null!;

    public string BzdCsiIdentWyst { get; set; } = null!;

    public DateTime? BzdCsiDataUr { get; set; }

    public string BzdCsiKraj { get; set; } = null!;

    public string BzdCsiWojew { get; set; } = null!;

    public string BzdCsiMiasto { get; set; } = null!;

    public virtual BnkZdarzenium BzdCsiBzd { get; set; } = null!;
}
