using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Trwale
{
    public int SrTSrTid { get; set; }

    public short SrTTyp { get; set; }

    public string SrTGrupa { get; set; } = null!;

    public int SrTLp { get; set; }

    public int? SrTVaNid { get; set; }

    public string SrTDokument { get; set; } = null!;

    public DateTime SrTDataZak { get; set; }

    public DateTime? SrTDataPrz { get; set; }

    public DateTime? SrTDataAmo { get; set; }

    public DateTime? SrTDataUmo { get; set; }

    public string SrTNazwa { get; set; } = null!;

    public int? SrTKatId { get; set; }

    public string SrTKategoria { get; set; } = null!;

    public string SrTKrst { get; set; } = null!;

    public string SrTNrInwent { get; set; } = null!;

    public int SrTUniqueNrInwBuster { get; set; }

    public string SrTKodKreskowy { get; set; } = null!;

    public int SrTUniqueKodKreskowyBuster { get; set; }

    public decimal SrTWartoscBilan { get; set; }

    public decimal SrTWartoscKoszt { get; set; }

    public byte SrTBilansowa { get; set; }

    public decimal SrTUlgaInwestyc { get; set; }

    public byte SrTMetoda { get; set; }

    public byte SrTMetodaBil { get; set; }

    public decimal SrTStawka { get; set; }

    public decimal SrTStawkaBil { get; set; }

    public decimal SrTWspolczynnik { get; set; }

    public decimal SrTWspolczynnikBil { get; set; }

    public byte SrTSezonowy { get; set; }

    public byte SrTSezonowyBil { get; set; }

    public byte SrTZawieszenieAmoKst { get; set; }

    public byte SrTZawieszenieAmoBil { get; set; }

    public int? SrTPrcId { get; set; }

    public string SrTPrcNazwisko { get; set; } = null!;

    public string SrTKontoGl { get; set; } = null!;

    public string SrTKontoUm { get; set; } = null!;

    public string SrTKontoAmKoszt { get; set; } = null!;

    public string SrTKontoAmRozn { get; set; } = null!;

    public DateTime? SrTDataLikw { get; set; }

    public byte SrTStan { get; set; }

    public string SrTLikwidacja { get; set; } = null!;

    public string SrTLikwDokument { get; set; } = null!;

    public int? SrTLikwDekId { get; set; }

    public byte SrTRodzaj { get; set; }

    public byte SrTWzestawie { get; set; }

    public byte SrTWbudowie { get; set; }

    public byte SrTUwzglKsgBadRozw { get; set; }

    public int? SrTZakId { get; set; }

    public string SrTOpis { get; set; } = null!;

    public byte SrTJpkRodzajDokNabycia { get; set; }

    public byte? SrTJpkMetodaAmortyzacji1 { get; set; }

    public byte? SrTJpkMetodaAmortyzacji2 { get; set; }

    public byte? SrTJpkMetodaAmortyzacji3 { get; set; }

    public byte SrTJpkCzestotliwoscOdpisu { get; set; }

    public byte? SrTJpkPrzyczynaWykreslenia { get; set; }

    public string? SrTJpkNumerKseF { get; set; }

    public byte SrTGenerujOdpisyNkup { get; set; }

    public string? SrTImportAppId { get; set; }

    public string? SrTImportRowId { get; set; }

    public int? SrTOpeZalId { get; set; }

    public int? SrTStaZalId { get; set; }

    public DateTime SrTTsZal { get; set; }

    public int? SrTOpeModId { get; set; }

    public int? SrTStaModId { get; set; }

    public DateTime SrTTsMod { get; set; }

    public string SrTOpeModKod { get; set; } = null!;

    public string SrTOpeModNazwisko { get; set; } = null!;

    public string SrTOpeZalKod { get; set; } = null!;

    public string SrTOpeZalNazwisko { get; set; } = null!;

    public virtual Kategorie? SrTKat { get; set; }

    public virtual PracKod? SrTPrc { get; set; }

    public virtual ICollection<TrwaleAtrybuty> TrwaleAtrybuties { get; set; } = new List<TrwaleAtrybuty>();

    public virtual ICollection<TrwaleCzesci> TrwaleCzescis { get; set; } = new List<TrwaleCzesci>();

    public virtual ICollection<TrwaleHist> TrwaleHists { get; set; } = new List<TrwaleHist>();

    public virtual ICollection<TrwaleMaska> TrwaleMaskas { get; set; } = new List<TrwaleMaska>();

    public virtual ICollection<TrwaleMiejscaUzytkowanium> TrwaleMiejscaUzytkowania { get; set; } = new List<TrwaleMiejscaUzytkowanium>();

    public virtual ICollection<TrwaleOsobyOdpowiedzialne> TrwaleOsobyOdpowiedzialnes { get; set; } = new List<TrwaleOsobyOdpowiedzialne>();

    public virtual ICollection<TrwalePowiazanium> TrwalePowiazania { get; set; } = new List<TrwalePowiazanium>();

    public virtual ICollection<TrwaleReklasyfikacje> TrwaleReklasyfikacjes { get; set; } = new List<TrwaleReklasyfikacje>();

    public virtual ICollection<TrwaleZapisyHist> TrwaleZapisyHists { get; set; } = new List<TrwaleZapisyHist>();

    public virtual ICollection<TrwaleZawieszeniaAmo> TrwaleZawieszeniaAmos { get; set; } = new List<TrwaleZawieszeniaAmo>();
}
