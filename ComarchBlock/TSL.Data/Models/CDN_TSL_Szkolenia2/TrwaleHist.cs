using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TrwaleHist
{
    public int SrHSrHid { get; set; }

    public int? SrHSrTid { get; set; }

    public short SrHTyp { get; set; }

    public string SrHGrupa { get; set; } = null!;

    public short SrHTypDokumentu { get; set; }

    public byte SrHRodzaj { get; set; }

    public DateTime? SrHDataOpe { get; set; }

    public decimal SrHKwotaKoszt { get; set; }

    public decimal SrHKwotaBilan { get; set; }

    public decimal SrHKwotaUm { get; set; }

    public decimal SrHKwotaAm { get; set; }

    public int? SrHDokumentTyp { get; set; }

    public int? SrHDokumentId { get; set; }

    public string? SrHNumer { get; set; }

    public int? SrHKatId { get; set; }

    public string SrHKategoria { get; set; } = null!;

    public byte SrHMetoda { get; set; }

    public byte SrHMetodaBil { get; set; }

    public decimal SrHStawka { get; set; }

    public decimal SrHStawkaBil { get; set; }

    public decimal SrHWspolczynnik { get; set; }

    public decimal SrHWspolczynnikBil { get; set; }

    public byte SrHUlga { get; set; }

    public int? SrHKprid { get; set; }

    public int? SrHDekId { get; set; }

    public DateTime? SrHDataPrzekazaniaOd { get; set; }

    public DateTime? SrHDataPrzekazaniaDo { get; set; }

    public int? SrHPrcId1 { get; set; }

    public string? SrHPrcImieNazwisko1 { get; set; }

    public string? SrHMiejsceUzytkowania1 { get; set; }

    public int? SrHPrcId2 { get; set; }

    public string? SrHPrcImieNazwisko2 { get; set; }

    public string? SrHMiejsceUzytkowania2 { get; set; }

    public DateTime? SrHLtdataAmo { get; set; }

    public DateTime? SrHLtdataAmoBil { get; set; }

    public byte SrHLtwyliczUm { get; set; }

    public byte SrHUwzglKsgBadRozw { get; set; }

    public int? SrHZakId { get; set; }

    public string? SrHOpis { get; set; }

    public int? SrHPreDekId { get; set; }

    public int? SrHOpeZalId { get; set; }

    public int? SrHStaZalId { get; set; }

    public DateTime SrHTsZal { get; set; }

    public int? SrHOpeModId { get; set; }

    public int? SrHStaModId { get; set; }

    public DateTime SrHTsMod { get; set; }

    public string SrHOpeModKod { get; set; } = null!;

    public string SrHOpeModNazwisko { get; set; } = null!;

    public string SrHOpeZalKod { get; set; } = null!;

    public string SrHOpeZalNazwisko { get; set; } = null!;

    public virtual Kategorie? SrHKat { get; set; }

    public virtual Trwale? SrHSrT { get; set; }

    public virtual ICollection<TrwaleHistPowiazanium> TrwaleHistPowiazania { get; set; } = new List<TrwaleHistPowiazanium>();
}
