using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DefinicjeKolumn
{
    public int DfkId { get; set; }

    public string? DfkNazwa { get; set; }

    public byte? DfkAktywny { get; set; }

    public int? DfkIdlisty { get; set; }

    public int? DfkIdformatki { get; set; }

    public int? DfkKontekst { get; set; }

    public string? DfkSql { get; set; }

    public string? DfkFormat { get; set; }

    public byte? DfkCzyDx { get; set; }

    public virtual ICollection<OpeDefKol> OpeDefKols { get; set; } = new List<OpeDefKol>();
}
