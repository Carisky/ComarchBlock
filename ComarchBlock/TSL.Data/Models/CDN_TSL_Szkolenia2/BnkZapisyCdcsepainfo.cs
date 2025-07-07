using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class BnkZapisyCdcsepainfo
{
    public int BzpCsiBzpCsiid { get; set; }

    public int BzpCsiBzpId { get; set; }

    public byte BzpCsiSekcja { get; set; }

    public byte BzpCsiOsobaTyp { get; set; }

    public string BzpCsiNazwa { get; set; } = null!;

    public string BzpCsiBicbei { get; set; } = null!;

    public string BzpCsiIdent { get; set; } = null!;

    public string BzpCsiIdentTyp { get; set; } = null!;

    public string BzpCsiIdentWyst { get; set; } = null!;

    public DateTime? BzpCsiDataUr { get; set; }

    public string BzpCsiKraj { get; set; } = null!;

    public string BzpCsiWojew { get; set; } = null!;

    public string BzpCsiMiasto { get; set; } = null!;

    public virtual BnkZapisy BzpCsiBzp { get; set; } = null!;
}
