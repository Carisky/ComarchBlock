using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PodElemVuegrupy
{
    public short PvgPoetyp { get; set; }

    public int PvgPoenumer { get; set; }

    public short PvgPoelp { get; set; }

    public int PvgId { get; set; }

    public string? PvgOpis { get; set; }

    public string? PvgKntAkronimJest { get; set; }

    public string? PvgKodKrajuJest { get; set; }

    public string? PvgKnAakronimJest { get; set; }

    public string? PvgKnAnipjest { get; set; }

    public byte? PvgPowrotnePrzemJest { get; set; }

    public decimal? PvgKwotaLjest { get; set; }

    public decimal? PvgKwotaMjest { get; set; }

    public string? PvgZastKntAkronimJest { get; set; }

    public string? PvgZastKodKrajuJest { get; set; }

    public string? PvgZastKnAakronimJest { get; set; }

    public string? PvgZastKnAnipjest { get; set; }

    public byte? PvgZastPowrotnePrzemJest { get; set; }

    public decimal? PvgZastKwotaLjest { get; set; }

    public decimal? PvgZastKwotaMjest { get; set; }

    public string? PvgKntAkronimBylo { get; set; }

    public string? PvgKodKrajuBylo { get; set; }

    public string? PvgKnAakronimBylo { get; set; }

    public string? PvgKnAnipbylo { get; set; }

    public byte? PvgPowrotnePrzemBylo { get; set; }

    public decimal? PvgKwotaLbylo { get; set; }

    public decimal? PvgKwotaMbylo { get; set; }

    public string? PvgZastKntAkronimBylo { get; set; }

    public string? PvgZastKodKrajuBylo { get; set; }

    public string? PvgZastKnAakronimBylo { get; set; }

    public string? PvgZastKnAnipbylo { get; set; }

    public byte? PvgZastPowrotnePrzemBylo { get; set; }

    public decimal? PvgZastKwotaLbylo { get; set; }

    public decimal? PvgZastKwotaMbylo { get; set; }

    public byte? PvgByloJest { get; set; }

    public virtual PodElem PodElem { get; set; } = null!;
}
