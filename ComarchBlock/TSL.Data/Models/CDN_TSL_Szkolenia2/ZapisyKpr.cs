using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ZapisyKpr
{
    public int KprKprid { get; set; }

    public short KprBufor { get; set; }

    public int KprRokMies { get; set; }

    public int KprLp { get; set; }

    public int? KprOrgId { get; set; }

    public DateTime KprDataOpe { get; set; }

    public string KprDokument { get; set; } = null!;

    public byte KprKorekta { get; set; }

    public short? KprPodmiotTyp { get; set; }

    public int? KprPodId { get; set; }

    public string KprKntNazwa1 { get; set; } = null!;

    public string KprKntNazwa2 { get; set; } = null!;

    public string KprKntNazwa3 { get; set; } = null!;

    public string KprKntKraj { get; set; } = null!;

    public string KprKntWojewodztwo { get; set; } = null!;

    public string KprKntPowiat { get; set; } = null!;

    public string KprKntGmina { get; set; } = null!;

    public string KprKntUlica { get; set; } = null!;

    public string KprKntNrDomu { get; set; } = null!;

    public string KprKntNrLokalu { get; set; } = null!;

    public string KprKntMiasto { get; set; } = null!;

    public string KprKntKodPocztowy { get; set; } = null!;

    public string KprKntPoczta { get; set; } = null!;

    public string KprKntAdres2 { get; set; } = null!;

    public string KprKntNipKraj { get; set; } = null!;

    public string KprKntNipE { get; set; } = null!;

    public int? KprKatId { get; set; }

    public string KprKategoria { get; set; } = null!;

    public decimal KprSprzedaz { get; set; }

    public decimal KprPozostale { get; set; }

    public decimal KprTowary { get; set; }

    public decimal KprUboczne { get; set; }

    public decimal KprReklama { get; set; }

    public decimal KprWynagrodz { get; set; }

    public decimal KprInne { get; set; }

    public decimal KprZaszlosci { get; set; }

    public decimal KprKosztyBiR { get; set; }

    public string KprOpisKosztow { get; set; } = null!;

    public string KprUwagi { get; set; } = null!;

    public byte KprSkreslony { get; set; }

    public byte KprZrodlo { get; set; }

    public string? KprImportRowId { get; set; }

    public int? KprOpeZalId { get; set; }

    public int? KprStaZalId { get; set; }

    public DateTime KprTsZal { get; set; }

    public int? KprOpeModId { get; set; }

    public int? KprStaModId { get; set; }

    public DateTime KprTsMod { get; set; }

    public string KprOpeModKod { get; set; } = null!;

    public string KprOpeModNazwisko { get; set; } = null!;

    public string KprOpeZalKod { get; set; } = null!;

    public string KprOpeZalNazwisko { get; set; } = null!;

    public string? KprOpisKorekta { get; set; }

    public byte KprKorektaZaplaconych { get; set; }

    public int KprSpisZnatury { get; set; }

    public DateTime KprDataGosp { get; set; }

    public int? KprZakId { get; set; }

    public int KprZakLp { get; set; }

    public virtual Kategorie? KprKat { get; set; }

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
