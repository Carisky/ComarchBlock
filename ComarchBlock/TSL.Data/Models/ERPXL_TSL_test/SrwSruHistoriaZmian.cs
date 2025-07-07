using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SrwSruHistoriaZmian
{
    public int SshzId { get; set; }

    public int? SshzSruId { get; set; }

    public short? SshzObiTyp { get; set; }

    public int? SshzObiNumer { get; set; }

    public string? SshzObiNazwa { get; set; }

    public byte? SshzTypZmiany { get; set; }

    public int? SshzCzasZmiany { get; set; }

    public string? SshzOpeIdent { get; set; }

    public string? SshzKolumna { get; set; }

    public string? SshzStaraWartosc { get; set; }

    public string? SshzNowaWartosc { get; set; }

    public virtual ICollection<SrwSruHistoriaZmianLinki> SrwSruHistoriaZmianLinkis { get; set; } = new List<SrwSruHistoriaZmianLinki>();
}
