using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class EwidDodNag
{
    public int EdnEdnid { get; set; }

    public int? EdnDdfId { get; set; }

    public string EdnNumerString { get; set; } = null!;

    public int EdnNumerNr { get; set; }

    public string? EdnNumerPelny { get; set; }

    public string EdnNumerObcy { get; set; } = null!;

    public DateTime EdnDataWys { get; set; }

    public DateTime EdnDataDok { get; set; }

    public DateTime EdnDataOpe { get; set; }

    public DateTime EdnDataKur { get; set; }

    public int EdnTyp { get; set; }

    public string EdnRejestr { get; set; } = null!;

    public int? EdnRokMies { get; set; }

    public int EdnLp { get; set; }

    public short? EdnPodmiotTyp { get; set; }

    public int? EdnPodId { get; set; }

    public string EdnNazwa1 { get; set; } = null!;

    public string EdnNazwa2 { get; set; } = null!;

    public string EdnNazwa3 { get; set; } = null!;

    public string EdnKraj { get; set; } = null!;

    public string EdnWojewodztwo { get; set; } = null!;

    public string EdnPowiat { get; set; } = null!;

    public string EdnGmina { get; set; } = null!;

    public string EdnUlica { get; set; } = null!;

    public string EdnNrDomu { get; set; } = null!;

    public string EdnNrLokalu { get; set; } = null!;

    public string EdnMiasto { get; set; } = null!;

    public string EdnKodPocztowy { get; set; } = null!;

    public string EdnPoczta { get; set; } = null!;

    public string EdnAdres2 { get; set; } = null!;

    public string EdnNipKraj { get; set; } = null!;

    public string EdnNipE { get; set; } = null!;

    public int? EdnKatId { get; set; }

    public short? EdnPodmiotZalTyp { get; set; }

    public int? EdnPodZalId { get; set; }

    public short? EdnPlatnikTyp { get; set; }

    public int? EdnPlatnikId { get; set; }

    public int? EdnPlatnikRachunekLp { get; set; }

    public string EdnPlatnikKraj { get; set; } = null!;

    public string EdnPlatnikWojewodztwo { get; set; } = null!;

    public string EdnPlatnikPowiat { get; set; } = null!;

    public string EdnPlatnikGmina { get; set; } = null!;

    public string EdnPlatnikUlica { get; set; } = null!;

    public string EdnPlatnikNrDomu { get; set; } = null!;

    public string EdnPlatnikNrLokalu { get; set; } = null!;

    public string EdnPlatnikMiasto { get; set; } = null!;

    public string EdnPlatnikKodPocztowy { get; set; } = null!;

    public string EdnPlatnikPoczta { get; set; } = null!;

    public string EdnPlatnikAdres2 { get; set; } = null!;

    public string EdnPlatnikNazwa1 { get; set; } = null!;

    public string EdnPlatnikNazwa2 { get; set; } = null!;

    public string EdnPlatnikNazwa3 { get; set; } = null!;

    public string EdnPlatnikRachunekNr { get; set; } = null!;

    public string EdnKategoria { get; set; } = null!;

    public decimal EdnKwotaRazemSys { get; set; }

    public byte EdnKontrolaSumy { get; set; }

    public decimal EdnKwotaRazem { get; set; }

    public string EdnWaluta { get; set; } = null!;

    public int EdnKursNumer { get; set; }

    public decimal EdnKursL { get; set; }

    public decimal EdnKursM { get; set; }

    public byte EdnPlatnosci { get; set; }

    public int? EdnFplId { get; set; }

    public DateTime EdnTermin { get; set; }

    public string? EdnMagazynZrodlowy { get; set; }

    public string? EdnMagazynDocelowy { get; set; }

    public int? EdnDekId { get; set; }

    public int? EdnPreDekId { get; set; }

    public int? EdnKprid { get; set; }

    public int? EdnRycId { get; set; }

    public string EdnOpis { get; set; } = null!;

    public string? EdnImportAppId { get; set; }

    public string? EdnImportRowId { get; set; }

    public DateTime? EdnTsExport { get; set; }

    public int? EdnOpeZalId { get; set; }

    public int? EdnStaZalId { get; set; }

    public DateTime EdnTsZal { get; set; }

    public int? EdnOpeModId { get; set; }

    public int? EdnStaModId { get; set; }

    public DateTime EdnTsMod { get; set; }

    public int? EdnZakId { get; set; }

    public int? EdnDnpId { get; set; }

    public string EdnOpeModKod { get; set; } = null!;

    public string EdnOpeModNazwisko { get; set; } = null!;

    public string EdnOpeZalKod { get; set; } = null!;

    public string EdnOpeZalNazwisko { get; set; } = null!;

    public virtual DokDefinicje? EdnDdf { get; set; }

    public virtual FormyPlatnosci? EdnFpl { get; set; }

    public virtual Kategorie? EdnKat { get; set; }

    public virtual ICollection<EwidDodElem> EwidDodElems { get; set; } = new List<EwidDodElem>();

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
