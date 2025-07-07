using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SqlRaporty
{
    public int SqRId { get; set; }

    public string? SqRNazwa { get; set; }

    public byte? SqRTyp { get; set; }

    public string? SqRAutor { get; set; }

    public string? SqRNrWersji { get; set; }

    public int? SqRDataUtw { get; set; }

    public int? SqRDataMod { get; set; }

    public int? SqRIloscWierszy { get; set; }

    public string? SqRHaslo { get; set; }

    public string? SqRHasloChk { get; set; }

    public short? SqRStaTyp { get; set; }

    public int? SqRStaFirma { get; set; }

    public int? SqRStaNumer { get; set; }

    public short? SqRStaLp { get; set; }

    public string? SqRKolumny { get; set; }

    public string? SqRZapytanie { get; set; }

    public string? SqRWarunek { get; set; }

    public byte? SqRFormat { get; set; }

    public string? SqRXslSpec { get; set; }

    public string? SqRPlikNazwa { get; set; }

    public byte? SqRPlik { get; set; }

    public string? SqRPlikKatalog { get; set; }

    public byte? SqRExe { get; set; }

    public string? SqRExeSpec { get; set; }

    public byte? SqREmail { get; set; }

    public string? SqREmailAdres { get; set; }

    public short? SqREmailAdresTyp { get; set; }

    public int? SqREmailAdresFirma { get; set; }

    public int? SqREmailAdresNumer { get; set; }

    public short? SqREmailAdresLp { get; set; }

    public string? SqROpis { get; set; }

    public byte? SqRPodglad { get; set; }

    public byte? SqRWynik { get; set; }

    public byte? SqRZapisujHistorie { get; set; }
}
