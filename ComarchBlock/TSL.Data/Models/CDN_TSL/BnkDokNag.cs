using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class BnkDokNag
{
    public int BdnBdnid { get; set; }

    public short BdnTyp { get; set; }

    public int? BdnDdfId { get; set; }

    public int BdnNumerNr { get; set; }

    public string BdnNumerString { get; set; } = null!;

    public string? BdnNumerPelny { get; set; }

    public DateTime BdnDataDok { get; set; }

    public short? BdnPodmiotTyp { get; set; }

    public int? BdnPodmiotId { get; set; }

    public int? BdnKatId { get; set; }

    public string BdnKategoria { get; set; } = null!;

    public string BdnWaluta { get; set; } = null!;

    public int BdnKursNumer { get; set; }

    public decimal BdnKursL { get; set; }

    public decimal BdnKursM { get; set; }

    public decimal BdnRazemKwota1 { get; set; }

    public decimal BdnRazemKwotaSys1 { get; set; }

    public decimal BdnRazemKwota2 { get; set; }

    public decimal BdnRazemKwotaSys2 { get; set; }

    public byte BdnOdsetkiTyp { get; set; }

    public decimal BdnOdsetkiStopa { get; set; }

    public decimal BdnOdsetkiPodatkoweProg { get; set; }

    public decimal BdnKosztyDodatkowe { get; set; }

    public decimal BdnKosztyDodatkoweSys { get; set; }

    public byte BdnGenerujPlatnosciKst { get; set; }

    public int? BdnFplIdkst { get; set; }

    public DateTime? BdnTerminKst { get; set; }

    public byte BdnGenerujPlatnosciOds { get; set; }

    public int? BdnFplIdods { get; set; }

    public DateTime? BdnTerminOds { get; set; }

    public string BdnUwagi { get; set; } = null!;

    public int? BdnDekId { get; set; }

    public int? BdnPreDekId { get; set; }

    public int BdnWindykacja { get; set; }

    public byte BdnUwzglNalez { get; set; }

    public byte BdnUwzglZobow { get; set; }

    public byte BdnUwzglPrzych { get; set; }

    public byte BdnUwzglRozch { get; set; }

    public byte BdnUwzglBufor { get; set; }

    public int? BdnOpeZalId { get; set; }

    public int? BdnStaZalId { get; set; }

    public DateTime BdnTsZal { get; set; }

    public int? BdnOpeModId { get; set; }

    public int? BdnStaModId { get; set; }

    public DateTime BdnTsMod { get; set; }

    public string BdnOpeModKod { get; set; } = null!;

    public string BdnOpeModNazwisko { get; set; } = null!;

    public string BdnOpeZalKod { get; set; } = null!;

    public string BdnOpeZalNazwisko { get; set; } = null!;

    public virtual DokDefinicje? BdnDdf { get; set; }

    public virtual Kategorie? BdnKat { get; set; }

    public virtual ICollection<BnkDokElem> BnkDokElems { get; set; } = new List<BnkDokElem>();

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
