using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class OpisyDniWolne
{
    public int OdwOdwId { get; set; }

    public string OdwSymbol { get; set; } = null!;

    public string OdwNazwa { get; set; } = null!;

    public short OdwStandardowy { get; set; }

    public byte OdwNieaktywny { get; set; }

    public int? OdwOpeZalId { get; set; }

    public int? OdwStaZalId { get; set; }

    public DateTime OdwTsZal { get; set; }

    public int? OdwOpeModId { get; set; }

    public int? OdwStaModId { get; set; }

    public DateTime OdwTsMod { get; set; }

    public string OdwOpeModKod { get; set; } = null!;

    public string OdwOpeModNazwisko { get; set; } = null!;

    public string OdwOpeZalKod { get; set; } = null!;

    public string OdwOpeZalNazwisko { get; set; } = null!;

    public string? OdwImportRowId { get; set; }

    public virtual ICollection<KalendDni> KalendDnis { get; set; } = new List<KalendDni>();

    public virtual ICollection<PracPlanDni> PracPlanDnis { get; set; } = new List<PracPlanDni>();

    public virtual ICollection<SerieKalPoz> SerieKalPozs { get; set; } = new List<SerieKalPoz>();
}
