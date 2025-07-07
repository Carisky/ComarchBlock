using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class Akordy
{
    public int AkrAkrId { get; set; }

    public int AkrPraId { get; set; }

    public string AkrNazwa { get; set; } = null!;

    public DateTime AkrWaznyOd { get; set; }

    public DateTime AkrWaznyDo { get; set; }

    public byte AkrNieaktywny { get; set; }

    public string? AkrImportRowId { get; set; }

    public virtual ICollection<AkordyHist> AkordyHists { get; set; } = new List<AkordyHist>();

    public virtual PracKod AkrPra { get; set; } = null!;
}
