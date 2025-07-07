using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PodElemVuepozycje
{
    public short PvpPoetyp { get; set; }

    public int PvpPoenumer { get; set; }

    public short PvpPoelp { get; set; }

    public int PvpId { get; set; }

    public int? PvpPvgid { get; set; }

    public int? PvpKntNumerJest { get; set; }

    public int? PvpKnaIdJest { get; set; }

    public int? PvpKnaIdGrupyJest { get; set; }

    public byte? PvpBylKntJest { get; set; }

    public string? PvpKntAkronimJest { get; set; }

    public string? PvpKodKrajuJest { get; set; }

    public string? PvpKnAakronimJest { get; set; }

    public string? PvpKnAnipjest { get; set; }

    public byte? PvpPowrotnePrzemJest { get; set; }

    public decimal? PvpKwotaLjest { get; set; }

    public decimal? PvpKwotaMjest { get; set; }

    public int? PvpZastKntNumerJest { get; set; }

    public int? PvpZastKnaIdJest { get; set; }

    public int? PvpZastKnaIdGrupyJest { get; set; }

    public byte? PvpZastBylKntJest { get; set; }

    public string? PvpZastKntAkronimJest { get; set; }

    public string? PvpZastKodKrajuJest { get; set; }

    public string? PvpZastKnAakronimJest { get; set; }

    public string? PvpZastKnAnipjest { get; set; }

    public byte? PvpZastPowrotnePrzemJest { get; set; }

    public decimal? PvpZastKwotaLjest { get; set; }

    public decimal? PvpZastKwotaMjest { get; set; }

    public int? PvpKntNumerBylo { get; set; }

    public int? PvpKnaIdBylo { get; set; }

    public int? PvpKnaIdGrupyBylo { get; set; }

    public byte? PvpBylKntBylo { get; set; }

    public string? PvpKntAkronimBylo { get; set; }

    public string? PvpKodKrajuBylo { get; set; }

    public string? PvpKnAakronimBylo { get; set; }

    public string? PvpKnAnipbylo { get; set; }

    public byte? PvpPowrotnePrzemBylo { get; set; }

    public decimal? PvpKwotaLbylo { get; set; }

    public decimal? PvpKwotaMbylo { get; set; }

    public int? PvpZastKntNumerBylo { get; set; }

    public int? PvpZastKnaIdBylo { get; set; }

    public int? PvpZastKnaIdGrupyBylo { get; set; }

    public byte? PvpZastBylKntBylo { get; set; }

    public string? PvpZastKntAkronimBylo { get; set; }

    public string? PvpZastKodKrajuBylo { get; set; }

    public string? PvpZastKnAakronimBylo { get; set; }

    public string? PvpZastKnAnipbylo { get; set; }

    public byte? PvpZastPowrotnePrzemBylo { get; set; }

    public decimal? PvpZastKwotaLbylo { get; set; }

    public decimal? PvpZastKwotaMbylo { get; set; }

    public string? PvpOpis { get; set; }

    public byte? PvpByloJest { get; set; }

    public virtual PodElem PodElem { get; set; } = null!;
}
