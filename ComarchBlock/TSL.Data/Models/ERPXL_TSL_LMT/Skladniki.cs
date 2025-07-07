using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Skladniki
{
    public short ScsGidtyp { get; set; }

    public int? ScsGidfirma { get; set; }

    public int ScsGidnumer { get; set; }

    public short ScsGidlp { get; set; }

    public string? ScsOpis { get; set; }

    public string? ScsOpisSql { get; set; }

    public byte? ScsOpisSqledycja { get; set; }

    public byte? ScsWykonuj { get; set; }

    public short? ScsWykonujOpcja { get; set; }

    public string? ScsKwota { get; set; }

    public string? ScsKwotaSql { get; set; }

    public byte? ScsKwotaSqledycja { get; set; }

    public string? ScsKwotaSysSql { get; set; }

    public string? ScsWarunek { get; set; }

    public string? ScsKontoDebet { get; set; }

    public short? ScsKdwyrazenie { get; set; }

    public string? ScsKontoCredit { get; set; }

    public short? ScsKcwyrazenie { get; set; }

    public byte? ScsZalozKontoDebet { get; set; }

    public byte? ScsZalozKontoCredit { get; set; }

    public string? ScsWarunekSymb { get; set; }

    public string? ScsKontoDebetSql { get; set; }

    public byte? ScsKontoDebetSqledycja { get; set; }

    public string? ScsKontoCreditSql { get; set; }

    public byte? ScsKontoCreditSqledycja { get; set; }

    public int? ScsSymbolKontaDebet { get; set; }

    public int? ScsSymbolKontaCredit { get; set; }

    public byte? ScsSkladniaWarunkuCw { get; set; }

    public byte? ScsSumuj { get; set; }

    public short? ScsSumujWg { get; set; }

    public byte? ScsSumujPoz { get; set; }

    public short? ScsTypKwoty { get; set; }

    public string? ScsOpisPozycjiSchematu { get; set; }

    public byte? ScsNieaktywna { get; set; }

    public virtual Schematy Schematy { get; set; } = null!;
}
