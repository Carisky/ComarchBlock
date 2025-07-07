using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class CrmdokumentyLinki
{
    public short CdlCrmtyp { get; set; }

    public int CdlCrmnumer { get; set; }

    public short CdlCrmlp { get; set; }

    public short CdlDokTyp { get; set; }

    public int CdlDokNumer { get; set; }

    public int? CdlTimeStamp { get; set; }

    public string? CdlOpis { get; set; }

    public int? CdlOpeNumer { get; set; }

    public byte? CdlTyp { get; set; }

    public decimal? CdlKwota { get; set; }

    public decimal? CdlProcent { get; set; }

    public byte? CdlPozycje { get; set; }

    public short? CdlKierunek { get; set; }
}
