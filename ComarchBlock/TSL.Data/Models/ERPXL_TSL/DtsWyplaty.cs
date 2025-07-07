using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DtsWyplaty
{
    public int DwpId { get; set; }

    public byte? DwpProgramId { get; set; }

    public int? DwpListaId { get; set; }

    public byte? DwpXl { get; set; }

    public int? DwpTstamp { get; set; }

    public short? DwpRok { get; set; }

    public short? DwpMiesiac { get; set; }

    public int? DwpData { get; set; }

    public int? DwpDataWyst { get; set; }

    public string? DwpNazwa { get; set; }

    public string? DwpOpis { get; set; }

    public string? DwpZnacznik { get; set; }

    public string? DwpKod { get; set; }

    public string? DwpImie { get; set; }

    public string? DwpNazwisko { get; set; }

    public int? DwpDzlId { get; set; }

    public string? DwpDzlKod { get; set; }

    public byte? DwpKategoria { get; set; }

    public byte? DwpLpTryb { get; set; }

    public int? DwpLpParentId { get; set; }

    public byte? DwpWypTryb { get; set; }

    public int? DwpWypParentId { get; set; }

    public short? DwpOddelegowani { get; set; }

    public string? DwpWaluta { get; set; }

    public decimal? DwpKursL { get; set; }

    public decimal? DwpKursM { get; set; }

    public virtual ICollection<DtsWyplatyKwoty> DtsWyplatyKwoties { get; set; } = new List<DtsWyplatyKwoty>();

    public virtual ICollection<DtsWyplatyOpi> DtsWyplatyOpis { get; set; } = new List<DtsWyplatyOpi>();
}
