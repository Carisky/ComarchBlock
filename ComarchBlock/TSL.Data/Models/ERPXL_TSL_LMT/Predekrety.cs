using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Predekrety
{
    public short PdtGidtyp { get; set; }

    public int? PdtGidfirma { get; set; }

    public int PdtGidnumer { get; set; }

    public short PdtGidlp { get; set; }

    public string? PdtOpis { get; set; }

    public decimal? PdtKwota { get; set; }

    public decimal? PdtKwotaWal { get; set; }

    public string? PdtKontoDebet { get; set; }

    public string? PdtKontoCredit { get; set; }

    public string? PdtWyrazenie { get; set; }

    public string? PdtKontoDebetDef { get; set; }

    public string? PdtKontoCreditDef { get; set; }

    public string? PdtKontoDebetR { get; set; }

    public string? PdtKontoCreditR { get; set; }

    public byte? PdtWykonuj { get; set; }

    public string? PdtWarunek { get; set; }

    public short? PdtZrotyp { get; set; }

    public int? PdtZrofirma { get; set; }

    public int? PdtZronumer { get; set; }

    public short? PdtZrolp { get; set; }

    public byte? PdtZalozKontoDebet { get; set; }

    public byte? PdtZalozKontoCredit { get; set; }

    public string? PdtWaluta { get; set; }

    public decimal? PdtKursL { get; set; }

    public decimal? PdtKursM { get; set; }

    public int? PdtSymbolKontaDebet { get; set; }

    public int? PdtSymbolKontaCredit { get; set; }

    public short? PdtTypKwoty { get; set; }

    public int? PdtDelnumer { get; set; }

    public short? PdtDellp { get; set; }

    public int? PdtDataWyst { get; set; }

    public int? PdtDataOper { get; set; }

    public string? PdtKontoDtnazwa { get; set; }

    public string? PdtKontoCtnazwa { get; set; }

    public short? PdtPdmTypDt { get; set; }

    public int? PdtPdmNumerDt { get; set; }

    public short? PdtPdmTypCt { get; set; }

    public int? PdtPdmNumerCt { get; set; }

    public int? PdtWycenaParId { get; set; }
}
