using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class KsiDokNag
{
    public int KdnKdnid { get; set; }

    public short KdnTyp { get; set; }

    public int KdnOobId { get; set; }

    public int? KdnDdfId { get; set; }

    public short KdnBufor { get; set; }

    public int KdnNumerNr { get; set; }

    public string KdnNumerString { get; set; } = null!;

    public string? KdnNumerPelny { get; set; }

    public DateTime KdnDataDok { get; set; }

    public DateTime? KdnTermin { get; set; }

    public string KdnKontoNumer { get; set; } = null!;

    public string KdnKontoNumerIdx { get; set; } = null!;

    public string KdnKontoNazwa { get; set; } = null!;

    public int? KdnAccId { get; set; }

    public int? KdnKatId { get; set; }

    public string? KdnKategoria { get; set; }

    public int? KdnFplId { get; set; }

    public string KdnWaluta { get; set; } = null!;

    public DateTime? KdnDataKur { get; set; }

    public int KdnKursNumer { get; set; }

    public decimal KdnKursL { get; set; }

    public decimal KdnKursM { get; set; }

    public decimal KdnRazemKwota1 { get; set; }

    public decimal KdnRazemKwotaSys1 { get; set; }

    public decimal KdnRazemKwota2 { get; set; }

    public decimal KdnRazemKwotaSys2 { get; set; }

    public int KdnOdsetkiTyp { get; set; }

    public decimal KdnOdsetkiStopa { get; set; }

    public string? KdnOpis { get; set; }

    public int? KdnDekId { get; set; }

    public int? KdnPreDekId { get; set; }

    public int? KdnOpeZalId { get; set; }

    public int? KdnStaZalId { get; set; }

    public DateTime KdnTsZal { get; set; }

    public int? KdnOpeModId { get; set; }

    public int? KdnStaModId { get; set; }

    public DateTime KdnTsMod { get; set; }

    public string KdnOpeModKod { get; set; } = null!;

    public string KdnOpeModNazwisko { get; set; } = null!;

    public string KdnOpeZalKod { get; set; } = null!;

    public string KdnOpeZalNazwisko { get; set; } = null!;

    public virtual DokDefinicje? KdnDdf { get; set; }

    public virtual ICollection<KsiDokElem> KsiDokElems { get; set; } = new List<KsiDokElem>();
}
