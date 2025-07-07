using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ZlcRemElem
{
    public short? ZreGidtyp { get; set; }

    public int? ZreGidfirma { get; set; }

    public int ZreGidnumer { get; set; }

    public short? ZreGidlp { get; set; }

    public int? ZreSsWid { get; set; }

    public short? ZrePozycja { get; set; }

    public short? ZreZrNtyp { get; set; }

    public int? ZreZrNfirma { get; set; }

    public int? ZreZrNnumer { get; set; }

    public short? ZreZrNlp { get; set; }

    public short? ZreZrdTyp { get; set; }

    public int? ZreZrdFirma { get; set; }

    public int? ZreZrdNumer { get; set; }

    public short? ZreZrdLp { get; set; }

    public short? ZreTwrTyp { get; set; }

    public int? ZreTwrFirma { get; set; }

    public int? ZreTwrNumer { get; set; }

    public short? ZreTwrLp { get; set; }

    public short? ZreKnttypO { get; set; }

    public int? ZreKntfirmaO { get; set; }

    public int? ZreKntnumerO { get; set; }

    public short? ZreKntlpO { get; set; }

    public decimal? ZreIlosc { get; set; }

    public string? ZreJmZ { get; set; }

    public byte? ZreTypJm { get; set; }

    public byte? ZreJmFormat { get; set; }

    public byte? ZreJmFormatZ { get; set; }

    public decimal? ZrePrzeliczM { get; set; }

    public decimal? ZrePrzeliczL { get; set; }

    public int? ZreTstamp { get; set; }

    public short? ZreCchTyp { get; set; }

    public int? ZreCchFirma { get; set; }

    public int? ZreCchNumer { get; set; }

    public short? ZreCchLp { get; set; }

    public string? ZreCecha { get; set; }

    public int? ZreStatusZglId { get; set; }

    public int? ZreMiejsceNaprawyId { get; set; }

    public int? ZreKodUszkodzeniaId { get; set; }

    public byte? ZreCzyPrzeglad { get; set; }

    public string? ZreOpis { get; set; }

    public short? ZreTyp { get; set; }

    public short? ZreReNtyp { get; set; }

    public int? ZreReNfirma { get; set; }

    public int? ZreReNnumer { get; set; }

    public short? ZreReNlp { get; set; }

    public decimal? ZreKosztRzeczywisty { get; set; }

    public decimal? ZreKosztEwidencyjny { get; set; }

    public short? ZreZcEtyp { get; set; }

    public int? ZreZcEfirma { get; set; }

    public int? ZreZcEnumer { get; set; }

    public short? ZreZcElp { get; set; }

    public virtual ZlcRemNag? ZreZrNnumerNavigation { get; set; }
}
