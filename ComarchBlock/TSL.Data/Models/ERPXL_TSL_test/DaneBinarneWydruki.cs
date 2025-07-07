using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class DaneBinarneWydruki
{
    public int DbwId { get; set; }

    public short DbwObiTyp { get; set; }

    public int DbwObiNumer { get; set; }

    public short DbwObiLp { get; set; }

    public string? DbwKod { get; set; }

    public string? DbwNazwa { get; set; }

    public string? DbwNumerDokumentu { get; set; }

    public int? DbwPodmiotTyp { get; set; }

    public int? DbwPodmiotFirma { get; set; }

    public int? DbwPodmiotNumer { get; set; }

    public int? DbwPodmiotLp { get; set; }

    public string? DbwPodmiot { get; set; }

    public string? DbwPodmiot2 { get; set; }

    public int? DbwDataWydruku { get; set; }

    public int? DbwDataDokumentu { get; set; }

    public string DbwOpeIdent { get; set; } = null!;

    public int? DbwRozmiar { get; set; }

    public int? DbwProcId { get; set; }

    public int? DbwFrsId { get; set; }

    public byte? DbwSystemowa { get; set; }

    public int? DbwDokTyp { get; set; }

    public int? DbwRodzaj { get; set; }
}
