using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ZamPlat
{
    public short? ZaPGidtyp { get; set; }

    public int? ZaPGidfirma { get; set; }

    public int ZaPGidnumer { get; set; }

    public short ZaPGidlp { get; set; }

    public string? ZaPWaluta { get; set; }

    public short? ZaPNrKursu { get; set; }

    public decimal? ZaPKursM { get; set; }

    public decimal? ZaPKursL { get; set; }

    public byte? ZaPTyp { get; set; }

    public int? ZaPTermin { get; set; }

    public byte? ZaPFormaNr { get; set; }

    public string? ZaPFormaNazwa { get; set; }

    public decimal? ZaPKwota { get; set; }

    public decimal? ZaPProcent { get; set; }

    public decimal? ZaPPozostaje { get; set; }

    public string? ZaPNotatki { get; set; }

    public int? ZaPTerminDni { get; set; }

    public short? ZaPTrNtyp { get; set; }

    public int? ZaPTrNnumer { get; set; }

    public virtual ZamNag ZaPGidnumerNavigation { get; set; } = null!;
}
