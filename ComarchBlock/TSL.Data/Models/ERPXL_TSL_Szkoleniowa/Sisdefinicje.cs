using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Sisdefinicje
{
    public short? SidGidtyp { get; set; }

    public int? SidGidfirma { get; set; }

    public int SidGidnumer { get; set; }

    public short? SidGidlp { get; set; }

    public string? SidNazwa { get; set; }

    public short? SidStatyp { get; set; }

    public int? SidStafirma { get; set; }

    public int? SidStanumer { get; set; }

    public short? SidStalp { get; set; }

    public byte? SidTyp { get; set; }

    public byte? SidBufor { get; set; }

    public string? SidOpis { get; set; }

    public string? SidAlgorytm { get; set; }

    public byte? SidArchiwalny { get; set; }

    public int? SidDfnid { get; set; }

    public byte? SidDfnkwotaWmr { get; set; }

    public virtual ICollection<SisdefinicjeKontum> SisdefinicjeKonta { get; set; } = new List<SisdefinicjeKontum>();

    public virtual ICollection<Siswartosci> Siswartoscis { get; set; } = new List<Siswartosci>();
}
