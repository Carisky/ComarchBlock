using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TrwaleAielem
{
    public int SrTaieSrTaieid { get; set; }

    public int SrTaieSrTainid { get; set; }

    public int SrTaieLp { get; set; }

    public int? SrTaieSrTid { get; set; }

    public string SrTaieNrInwent { get; set; } = null!;

    public int SrTaieUniqueNrInwBuster { get; set; }

    public string SrTaieKodKreskowy { get; set; } = null!;

    public int SrTaieUniqueKodKreskowyBuster { get; set; }

    public string SrTaieNazwa { get; set; } = null!;

    public string SrTaieGrupa { get; set; } = null!;

    public decimal SrTaieWartoscPocz { get; set; }

    public int SrTaieIlosc { get; set; }

    public int SrTaieStanBiez { get; set; }

    public int? SrTaieRoznica { get; set; }

    public virtual TrwaleAinag SrTaieSrTain { get; set; } = null!;
}
