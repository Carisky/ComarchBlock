using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ZamRealizacja
{
    public int ZaRZamGid { get; set; }

    public int? ZaRWypGid { get; set; }

    public string? ZaRNrPrzesylki { get; set; }

    public string? ZaRLinkPrzesylki { get; set; }

    public int? ZaRDostawaWszystkoPl { get; set; }

    public int? ZaRPlatnoscWszystkoPl { get; set; }

    public int? ZaRStatusWszystkoPl { get; set; }

    public byte? ZaRNieAktualizujWszystkoPl { get; set; }

    public int? ZaRDanePrzesylkiLm { get; set; }

    public int? ZaRStatusWszystkoPlLm { get; set; }

    public int? ZaRKurierId { get; set; }

    public virtual ZamNag ZaRZamG { get; set; } = null!;
}
