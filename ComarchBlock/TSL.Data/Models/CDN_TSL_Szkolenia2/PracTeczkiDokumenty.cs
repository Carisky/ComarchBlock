using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PracTeczkiDokumenty
{
    public int PtdPtdId { get; set; }

    public int PtdPrtId { get; set; }

    public string PtdNazwa { get; set; } = null!;

    public int PtdRodzajLokalizacji { get; set; }

    public string PtdSciezka { get; set; } = null!;

    public int? PtdDabId { get; set; }

    public byte PtdPodpis { get; set; }

    public short PtdFileMode { get; set; }

    public string? PtdNazwaPliku { get; set; }

    public short PtdWersja { get; set; }

    public int? PtdArchiwalny { get; set; }

    public short? PtdWbazie { get; set; }

    public int? PtdStaEditId { get; set; }

    public int? PtdOpeEditId { get; set; }

    public int? PtdOpeZalId { get; set; }

    public int? PtdStaZalId { get; set; }

    public DateTime PtdTsZal { get; set; }

    public int? PtdOpeModId { get; set; }

    public int? PtdStaModId { get; set; }

    public DateTime PtdTsMod { get; set; }

    public string PtdOpeModKod { get; set; } = null!;

    public string PtdOpeModNazwisko { get; set; } = null!;

    public string PtdOpeZalKod { get; set; } = null!;

    public string PtdOpeZalNazwisko { get; set; } = null!;

    public DateTime? PtdDataPodpisu { get; set; }

    public DateTime? PtdDataEksportu { get; set; }

    public virtual PracTeczki PtdPrt { get; set; } = null!;
}
