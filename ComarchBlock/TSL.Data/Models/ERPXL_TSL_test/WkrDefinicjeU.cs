using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class WkrDefinicjeU
{
    public int? WkDuStanId { get; set; }

    public int WkDuWkDid { get; set; }

    public short? WkDuFormat { get; set; }

    public string? WkDuXslSpec { get; set; }

    public string? WkDuPlikNazwa { get; set; }

    public short? WkDuPlik { get; set; }

    public string? WkDuPlikKatalog { get; set; }

    public short? WkDuDolaczDoPliku { get; set; }

    public short? WkDuExe { get; set; }

    public string? WkDuExeSpec { get; set; }

    public short? WkDuEmail { get; set; }

    public string? WkDuEmailAdres { get; set; }

    public short? WkDuEmailAdresPodmiotTyp { get; set; }

    public int? WkDuEmailAdresPodmiotId { get; set; }

    public short? WkDuPodglad { get; set; }

    public short? WkDuTimeout { get; set; }

    public byte? WkDuZapisujHistorie { get; set; }
}
