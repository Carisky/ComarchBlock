using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfDshead
{
    public int DshId { get; set; }

    public int DshDfhid { get; set; }

    public string? DshXml { get; set; }

    public DateTime? DshCreateData { get; set; }

    public bool? DshArchves { get; set; }

    public virtual ICollection<DfConfCfcardDokFlow> DfConfCfcardDokFlows { get; set; } = new List<DfConfCfcardDokFlow>();

    public virtual ICollection<DfConfDsdictionary> DfConfDsdictionaries { get; set; } = new List<DfConfDsdictionary>();

    public virtual ICollection<DfConfDsscheme> DfConfDsschemes { get; set; } = new List<DfConfDsscheme>();

    public virtual DfConfDssetting? DfConfDssetting { get; set; }

    public virtual ICollection<DfWork> DfWorks { get; set; } = new List<DfWork>();

    public virtual DfHeadDokumentFlow DshDfh { get; set; } = null!;
}
