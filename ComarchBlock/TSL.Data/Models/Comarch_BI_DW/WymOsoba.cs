using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymOsoba
{
    public int OsoRowId { get; set; }

    public int OsoId { get; set; }

    public int OsoZrodgid { get; set; }

    public string OsoCleanOrgId { get; set; } = null!;

    public string OsoDirtyOrgId { get; set; } = null!;

    public string? OsoNazwa { get; set; }

    public string? OsoTytul { get; set; }

    public string? OsoParDirtyOrgId { get; set; }

    public string? OsoParCleanOrgId { get; set; }

    public int? OsoParGid { get; set; }

    public DateTime OsoTsinsert { get; set; }

    public DateTime OsoTsupdate { get; set; }

    public DateTime OsoTimeFrom { get; set; }

    public DateTime? OsoTimeTo { get; set; }

    public int OsoChecksumKimball1 { get; set; }

    public int OsoChecksumKimball2 { get; set; }

    public int OsoUpdateTransformationId { get; set; }

    public int? OsoUpdateSubTransformationId { get; set; }

    public int OsoInsertTransformationId { get; set; }

    public int? OsoInsertSubTransformationId { get; set; }

    public byte[] OsoRowVersion { get; set; } = null!;

    public string? OsoDzial { get; set; }

    public string? OsoStanowisko { get; set; }

    public string? OsoTelefon { get; set; }

    public string? OsoEmail { get; set; }

    public string? OsoFax { get; set; }

    public string? OsoKomorka { get; set; }

    public virtual ICollection<FktKonwersacje> FktKonwersacjes { get; set; } = new List<FktKonwersacje>();

    public virtual WymZrodloDanych OsoZrodg { get; set; } = null!;
}
