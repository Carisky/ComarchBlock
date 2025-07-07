using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TrwaleHistPowiazanium
{
    public int SrHpSrHpid { get; set; }

    public int? SrHpSrHid { get; set; }

    public int? SrHpDokumentTyp { get; set; }

    public int? SrHpDokumentId { get; set; }

    public DateTime? SrHpDataDok { get; set; }

    public string? SrHpNumer { get; set; }

    public decimal SrHpKwota { get; set; }

    public string? SrHpOpis { get; set; }

    public virtual TrwaleHist? SrHpSrH { get; set; }
}
