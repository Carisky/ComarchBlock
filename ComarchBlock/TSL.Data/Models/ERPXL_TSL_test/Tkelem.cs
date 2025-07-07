using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Tkelem
{
    public short TkeGidtyp { get; set; }

    public int? TkeGidfirma { get; set; }

    public int TkeGidnumer { get; set; }

    public short TkeGidlp { get; set; }

    public short? TkePozycja { get; set; }

    public short? TkeTwrTyp { get; set; }

    public int? TkeTwrFirma { get; set; }

    public int? TkeTwrNumer { get; set; }

    public short? TkeTwrLp { get; set; }

    public short? TkeKntTyp { get; set; }

    public int? TkeKntFirma { get; set; }

    public int? TkeKntNumer { get; set; }

    public short? TkeKntLp { get; set; }

    public short? TkeAkwTyp { get; set; }

    public int? TkeAkwFirma { get; set; }

    public int? TkeAkwNumer { get; set; }

    public short? TkeAkwLp { get; set; }

    public int? TkeTknTstamp { get; set; }

    public decimal? TkeIlosc { get; set; }

    public byte? TkeJmformat { get; set; }

    public string? TkeJmZ { get; set; }

    public byte? TkeJmFormatZ { get; set; }

    public byte? TkeTypJm { get; set; }

    public decimal? TkePrzeliczM { get; set; }

    public decimal? TkePrzeliczL { get; set; }

    public string? TkeWaluta { get; set; }

    public short? TkeNrKursu { get; set; }

    public decimal? TkeKursM { get; set; }

    public decimal? TkeKursL { get; set; }

    public short? TkeDoZwrotu { get; set; }

    public int? TkeTerminZwrotu { get; set; }

    public decimal? TkeKosztKsiegowy { get; set; }

    public decimal? TkeKosztRzeczywisty { get; set; }

    public decimal? TkeWartosc { get; set; }

    public decimal? TkeWartoscWal { get; set; }

    public virtual Tknag TkeGidnumerNavigation { get; set; } = null!;

    public virtual ICollection<Tkselem> Tkselems { get; set; } = new List<Tkselem>();
}
