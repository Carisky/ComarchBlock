using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KompensatyNag
{
    public int KpnKpnid { get; set; }

    public int? KpnDdfId { get; set; }

    public int KpnNumerNr { get; set; }

    public string KpnNumerString { get; set; } = null!;

    public string? KpnNumerPelny { get; set; }

    public string KpnNumerObcy { get; set; } = null!;

    public string? KpnNumer { get; set; }

    public DateTime KpnDataDok { get; set; }

    public short? KpnPodmiotTyp { get; set; }

    public int? KpnPodmiotId { get; set; }

    public int? KpnKatId { get; set; }

    public string KpnKategoria { get; set; } = null!;

    public string KpnWaluta { get; set; } = null!;

    public string KpnKontoWn { get; set; } = null!;

    public string KpnKontoMa { get; set; } = null!;

    public int? KpnDekId { get; set; }

    public int? KpnPreDekId { get; set; }

    public string KpnOpis { get; set; } = null!;

    public decimal KpnRazemKwotaRoz { get; set; }

    public string? KpnImportAppId { get; set; }

    public string? KpnImportRowId { get; set; }

    public DateTime? KpnTsExport { get; set; }

    public int? KpnOpeZalId { get; set; }

    public int? KpnStaZalId { get; set; }

    public DateTime KpnTsZal { get; set; }

    public int? KpnOpeModId { get; set; }

    public int? KpnStaModId { get; set; }

    public DateTime KpnTsMod { get; set; }

    public string KpnOpeModKod { get; set; } = null!;

    public string KpnOpeModNazwisko { get; set; } = null!;

    public string KpnOpeZalKod { get; set; } = null!;

    public string KpnOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<KompensatyElem> KompensatyElems { get; set; } = new List<KompensatyElem>();

    public virtual DokDefinicje? KpnDdf { get; set; }

    public virtual Kategorie? KpnKat { get; set; }

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
