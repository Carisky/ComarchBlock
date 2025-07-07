using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DlgDokumenty
{
    public int DldDldid { get; set; }

    public int DldDleid { get; set; }

    public int DldRozliczac { get; set; }

    public int DldTyp { get; set; }

    public int DldDokumentTyp { get; set; }

    public int DldDokumentId { get; set; }

    public decimal DldKwotaRozliczenia { get; set; }

    public string DldOpis { get; set; } = null!;

    public virtual DlgElem DldDle { get; set; } = null!;
}
