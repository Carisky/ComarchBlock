using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class WysRelacje
{
    public int WyrIdPaczki { get; set; }

    public short WyrDokTyp { get; set; }

    public int? WyrDokFirma { get; set; }

    public int WyrDokNumer { get; set; }

    public short WyrDokLp { get; set; }

    public short WyrDokSubLp { get; set; }

    public byte? WyrStatus { get; set; }

    public decimal? WyrIlosc { get; set; }

    public byte? WyrKierunek { get; set; }

    public int WyrId { get; set; }

    public virtual WysPaczki WyrIdPaczkiNavigation { get; set; } = null!;
}
