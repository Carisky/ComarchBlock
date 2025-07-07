using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class PhysicalSource
{
    public int PsrcId { get; set; }

    public int PsrcLsrcid { get; set; }

    public string PsrcSrtid { get; set; } = null!;

    public string? PsrcConnectionString { get; set; }

    public string? PsrcFolderName { get; set; }

    public bool PsrcIsUnicode { get; set; }

    public bool PsrcMustBeArchived { get; set; }

    public bool PsrcMustBeBackuped { get; set; }

    public DateTime PsrcTsinsert { get; set; }

    public DateTime PsrcTsupdate { get; set; }

    public byte[] PsrcRowVersion { get; set; } = null!;

    public bool PsrcIsPattern { get; set; }

    public bool PsrcUseCustomPatternConfiguration { get; set; }

    public string PsrcName { get; set; } = null!;

    public bool PsrcIsWarehouse { get; set; }

    public string? PsrcDescription { get; set; }

    public bool? PsrcIsCentral { get; set; }

    public string PsrcType { get; set; } = null!;

    public string? PsrcMainUrl { get; set; }

    public string? PsrcQualifier { get; set; }

    public virtual ICollection<EtlComponent> EtlComponentEtlcPsrcs { get; set; } = new List<EtlComponent>();

    public virtual ICollection<EtlComponent> EtlComponentEtlcWritebackPsrcs { get; set; } = new List<EtlComponent>();

    public virtual ICollection<EtlNode> EtlNodes { get; set; } = new List<EtlNode>();

    public virtual ICollection<FieldLink> FieldLinks { get; set; } = new List<FieldLink>();

    public virtual LogicalSource PsrcLsrc { get; set; } = null!;

    public virtual SourceType PsrcSrt { get; set; } = null!;

    public virtual ICollection<TableLink> TableLinks { get; set; } = new List<TableLink>();
}
