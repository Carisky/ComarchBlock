using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymRodzajZakupu
{
    public int RdzChecksumKimball1 { get; set; }

    public int RdzChecksumKimball2 { get; set; }

    public string RdzDirtyOrgId { get; set; } = null!;

    public int RdzId { get; set; }

    public int? RdzInsertSubTransformationId { get; set; }

    public int RdzInsertTransformationId { get; set; }

    public string RdzOrgId { get; set; } = null!;

    public string? RdzParCleanOrgId { get; set; }

    public string? RdzParDirtyOrgId { get; set; }

    public int? RdzParGid { get; set; }

    public int RdzRowId { get; set; }

    public byte[] RdzRowVersion { get; set; } = null!;

    public DateTime RdzTimeFrom { get; set; }

    public DateTime? RdzTimeTo { get; set; }

    public DateTime RdzTsinsert { get; set; }

    public DateTime RdzTsupdate { get; set; }

    public int? RdzUpdateSubTransformationId { get; set; }

    public int RdzUpdateTransformationId { get; set; }

    public int RdzZrodgid { get; set; }

    public string? RdzAktualneOrgId { get; set; }

    public string RdzNazwa { get; set; } = null!;

    public string? RdzOpis { get; set; }

    public string? RdzOrgParId { get; set; }

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual WymZrodloDanych RdzZrodg { get; set; } = null!;
}
