using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PracZestaw
{
    public int PzePzeId { get; set; }

    public int PzePraId { get; set; }

    public byte? PzeTryb { get; set; }

    public int? PzeParentId { get; set; }

    public DateTime PzeOkresOd { get; set; }

    public DateTime PzeOkresDo { get; set; }

    public int PzeIlosc { get; set; }

    public DateTime PzeCzas { get; set; }

    public DateTime PzeCzasNoc { get; set; }

    public DateTime PzeCzasWolne { get; set; }

    public DateTime PzeCzasSw { get; set; }

    public DateTime PzeNadgodziny50 { get; set; }

    public DateTime PzeNadgodziny100 { get; set; }

    public DateTime PzeNadgodzinySw { get; set; }

    public int? PzeOpeZalId { get; set; }

    public int? PzeStaZalId { get; set; }

    public DateTime PzeTsZal { get; set; }

    public int? PzeOpeModId { get; set; }

    public int? PzeStaModId { get; set; }

    public DateTime PzeTsMod { get; set; }

    public string PzeOpeModKod { get; set; } = null!;

    public string PzeOpeModNazwisko { get; set; } = null!;

    public string PzeOpeZalKod { get; set; } = null!;

    public string PzeOpeZalNazwisko { get; set; } = null!;

    public byte PzeZrodlo { get; set; }

    public string? PzeImportRowId { get; set; }

    public virtual ICollection<PracZestawElem> PracZestawElems { get; set; } = new List<PracZestawElem>();

    public virtual PracKod PzePra { get; set; } = null!;

    public virtual ICollection<WypSkladniki> WypSkladnikis { get; set; } = new List<WypSkladniki>();
}
