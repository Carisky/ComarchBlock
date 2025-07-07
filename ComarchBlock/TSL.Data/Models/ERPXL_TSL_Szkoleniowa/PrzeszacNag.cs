using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PrzeszacNag
{
    public short? PsnGidtyp { get; set; }

    public int? PsnGidfirma { get; set; }

    public int PsnGidnumer { get; set; }

    public short? PsnGidlp { get; set; }

    public int? PsnOkres { get; set; }

    public int? PsnOkresNastepny { get; set; }

    public int? PsnOkrPoczatek { get; set; }

    public string? PsnOkrSymbol { get; set; }

    public int? PsnNumer { get; set; }

    public int? PsnData { get; set; }

    public byte? PsnZaksiegowanoK { get; set; }

    public byte? PsnZaksiegowanoP { get; set; }

    public byte? PsnNieKsiegowac { get; set; }

    public string? PsnOpis { get; set; }

    public short? PsnOpeTypW { get; set; }

    public int? PsnOpeFirmaW { get; set; }

    public int? PsnOpeNumerW { get; set; }

    public short? PsnOpeLpW { get; set; }

    public short? PsnOpeTypK { get; set; }

    public int? PsnOpeFirmaK { get; set; }

    public int? PsnOpeNumerK { get; set; }

    public short? PsnOpeLpK { get; set; }

    public short? PsnOpeTypP { get; set; }

    public int? PsnOpeFimaP { get; set; }

    public int? PsnOpeNumerP { get; set; }

    public short? PsnOpeLpP { get; set; }

    public virtual ICollection<PrzeszacElem> PrzeszacElems { get; set; } = new List<PrzeszacElem>();
}
