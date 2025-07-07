using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DekretyNag
{
    public int DeNDeNid { get; set; }

    public int DeNTyp { get; set; }

    public int DeNOobId { get; set; }

    public int? DeNDdfId { get; set; }

    public int? DeNNumerNr { get; set; }

    public string? DeNNumerString { get; set; }

    public string? DeNNumerPelny { get; set; }

    public int DeNDziId { get; set; }

    public string DeNDziennik { get; set; } = null!;

    public int? DeNOrgId { get; set; }

    public byte? DeNStorno { get; set; }

    public int DeNNrDziennika { get; set; }

    public int DeNNrKsiegi { get; set; }

    public string DeNIdentKsieg { get; set; } = null!;

    public string? DeNIdentKsiegNumeracja { get; set; }

    public int? DeNIdentKsiegDdfId { get; set; }

    public byte DeNBufor { get; set; }

    public DateTime DeNDataDok { get; set; }

    public DateTime DeNDataWys { get; set; }

    public DateTime DeNDataOpe { get; set; }

    public string DeNDokument { get; set; } = null!;

    public short? DeNPodmiotTyp { get; set; }

    public int? DeNPodmiotId { get; set; }

    public int? DeNKatId { get; set; }

    public string DeNKategoria { get; set; } = null!;

    public decimal DeNKwotaWn { get; set; }

    public decimal DeNKwotaMa { get; set; }

    public byte DeNZrodlo { get; set; }

    public short? DeNWzorzecTyp { get; set; }

    public int? DeNWzorzecId { get; set; }

    public byte? DeNTypRozliczenia { get; set; }

    public int? DeNOpeZalId { get; set; }

    public int? DeNStaZalId { get; set; }

    public DateTime DeNTsZal { get; set; }

    public int? DeNOpeModId { get; set; }

    public int? DeNStaModId { get; set; }

    public DateTime DeNTsMod { get; set; }

    public string DeNOpeModKod { get; set; } = null!;

    public string DeNOpeModNazwisko { get; set; } = null!;

    public string DeNOpeZalKod { get; set; } = null!;

    public string DeNOpeZalNazwisko { get; set; } = null!;

    public DateTime? DeNTsModB { get; set; }

    public byte DeNKorekta { get; set; }

    public string? DeNOpisKorekta { get; set; }

    public byte DeNKorektaZaplaconych { get; set; }

    public DateTime? DeNTsExport { get; set; }

    public string? DeNIdentKsiegStr { get; set; }

    public int? DeNIdentKsiegNr { get; set; }

    public virtual Kategorie? DeNKat { get; set; }

    public virtual ICollection<DekretyElem> DekretyElems { get; set; } = new List<DekretyElem>();

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
