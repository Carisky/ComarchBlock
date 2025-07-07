using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class BnkRozKwotyView
{
    public int BrkvBrkid { get; set; }

    public decimal BrkvKwota { get; set; }

    public decimal BrkvKwotaSysL { get; set; }

    public decimal BrkvKwotaSysP { get; set; }

    public decimal BrkvRoznicaKursowaSys { get; set; }

    public int BrkvDdfId { get; set; }

    public string BrkvNumerString { get; set; } = null!;

    public int BrkvNumerNr { get; set; }

    public string? BrkvNumerPelny { get; set; }

    public DateTime BrkvDataDok { get; set; }

    public int BrkvZwloka { get; set; }

    public short? BrkvLdokTyp { get; set; }

    public int? BrkvLdokId { get; set; }

    public short? BrkvPdokTyp { get; set; }

    public int? BrkvPdokId { get; set; }

    public int? BrkvDekId { get; set; }

    public int? BrkvDek2Id { get; set; }

    public int? BrkvKprid { get; set; }

    public byte BrkvKolumnaKpr { get; set; }

    public string BrkvKontoWn1 { get; set; } = null!;

    public string BrkvKontoMa1 { get; set; } = null!;

    public string BrkvKontoWn2 { get; set; } = null!;

    public string BrkvKontoMa2 { get; set; } = null!;

    public short BrkvAutoOffLine { get; set; }

    public DateTime? BrkvTsExport { get; set; }

    public string? BrkvImportAppId { get; set; }

    public string BrkvImportRowId { get; set; } = null!;

    public int? BrkvOpeZalId { get; set; }

    public int? BrkvStaZalId { get; set; }

    public DateTime BrkvTsZal { get; set; }

    public int? BrkvOpeModId { get; set; }

    public int? BrkvStaModId { get; set; }

    public DateTime BrkvTsMod { get; set; }

    public int? BrkvDokumentLp { get; set; }

    public string? BrkvWaluta { get; set; }

    public short? BrkvDokTyp1 { get; set; }

    public int? BrkvDokId1 { get; set; }

    public string? BrkvNumer1 { get; set; }

    public DateTime? BrkvData1 { get; set; }

    public DateTime? BrkvTermin1 { get; set; }

    public int? BrkvBraId1 { get; set; }

    public int? BrkvKursNumer1 { get; set; }

    public decimal? BrkvKursL1 { get; set; }

    public decimal? BrkvKursM1 { get; set; }

    public string? BrkvOpis1 { get; set; }

    public string? BrkvKontoPrzeciwstawne1 { get; set; }

    public short? BrkvPodmiotTyp1 { get; set; }

    public int? BrkvPodmiotId1 { get; set; }

    public decimal? BrkvKwota1 { get; set; }

    public decimal? BrkvKwotaSys1 { get; set; }

    public decimal BrkvKwotaRozSys1 { get; set; }

    public string? BrkvTyp1 { get; set; }

    public int? BrkvWynagrodzenie1 { get; set; }

    public short? BrkvDokTyp2 { get; set; }

    public int? BrkvDokId2 { get; set; }

    public string? BrkvNumer2 { get; set; }

    public DateTime? BrkvData2 { get; set; }

    public DateTime? BrkvTermin2 { get; set; }

    public int? BrkvBraId2 { get; set; }

    public int? BrkvKursNumer2 { get; set; }

    public decimal? BrkvKursL2 { get; set; }

    public decimal? BrkvKursM2 { get; set; }

    public string? BrkvOpis2 { get; set; }

    public string? BrkvKontoPrzeciwstawne2 { get; set; }

    public short? BrkvPodmiotTyp2 { get; set; }

    public int? BrkvPodmiotId2 { get; set; }

    public decimal? BrkvKwota2 { get; set; }

    public decimal? BrkvKwotaSys2 { get; set; }

    public decimal BrkvKwotaRozSys2 { get; set; }

    public string? BrkvTyp2 { get; set; }

    public int? BrkvWynagrodzenie2 { get; set; }

    public int? BrkvAutomatyczny { get; set; }
}
