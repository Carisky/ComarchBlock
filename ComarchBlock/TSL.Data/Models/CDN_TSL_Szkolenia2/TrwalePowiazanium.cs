using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TrwalePowiazanium
{
    public int SrTpSrtPid { get; set; }

    public int? SrTpSrTid { get; set; }

    public int? SrTpDokumentTyp { get; set; }

    public int? SrTpDokumentId { get; set; }

    public DateTime? SrTpDataDok { get; set; }

    public string? SrTpNumer { get; set; }

    public decimal SrTpKwota { get; set; }

    public string? SrTpOpis { get; set; }

    public virtual Trwale? SrTpSrT { get; set; }
}
