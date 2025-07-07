using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TrwaleAtrybutyView
{
    public string? SravSrAvid { get; set; }

    public int? SravSrAid { get; set; }

    public int? SravDeAid { get; set; }

    public int SravSrTid { get; set; }

    public int? SravWypId { get; set; }

    public short? SravAtrybutFormat { get; set; }

    public string? SravAtrybutKod { get; set; }

    public string? SravAtrybutNazwa { get; set; }

    public string? SravAtrybutWartosc { get; set; }

    public short SravTyp { get; set; }

    public string SravGrupa { get; set; } = null!;

    public int SravLp { get; set; }

    public int? SravVaNid { get; set; }

    public string SravDokument { get; set; } = null!;

    public DateTime SravDataZak { get; set; }

    public DateTime? SravDataPrz { get; set; }

    public DateTime? SravDataAmo { get; set; }

    public DateTime? SravDataUmo { get; set; }

    public string SravNazwa { get; set; } = null!;

    public int? SravKatId { get; set; }

    public string SravKategoria { get; set; } = null!;

    public string SravKrst { get; set; } = null!;

    public string SravNrInwent { get; set; } = null!;

    public decimal SravWartoscBilan { get; set; }

    public decimal SravWartoscKoszt { get; set; }

    public byte SravBilansowa { get; set; }

    public decimal SravUlgaInwestyc { get; set; }

    public byte SravMetoda { get; set; }

    public byte SravMetodaBil { get; set; }

    public decimal SravStawka { get; set; }

    public decimal SravStawkaBil { get; set; }

    public decimal SravWspolczynnik { get; set; }

    public decimal SravWspolczynnikBil { get; set; }

    public byte SravSezonowy { get; set; }

    public byte SravSezonowyBil { get; set; }

    public int? SravPrcId { get; set; }

    public string SravPrcNazwisko { get; set; } = null!;

    public string SravKontoGl { get; set; } = null!;

    public string SravKontoUm { get; set; } = null!;

    public string SravKontoAmKoszt { get; set; } = null!;

    public string SravKontoAmRozn { get; set; } = null!;

    public DateTime? SravDataLikw { get; set; }

    public byte SravStan { get; set; }

    public string SravLikwidacja { get; set; } = null!;

    public string SravLikwDokument { get; set; } = null!;

    public int? SravLikwDekId { get; set; }

    public string SravOpis { get; set; } = null!;

    public int? SravZakId { get; set; }

    public int? SravOpeZalId { get; set; }

    public int? SravStaZalId { get; set; }

    public DateTime SravTsZal { get; set; }

    public int? SravOpeModId { get; set; }

    public int? SravStaModId { get; set; }

    public DateTime SravTsMod { get; set; }
}
