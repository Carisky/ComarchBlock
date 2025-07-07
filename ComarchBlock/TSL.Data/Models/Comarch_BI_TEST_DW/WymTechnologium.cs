using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymTechnologium
{
    public int TchChecksumKimball1 { get; set; }

    public int TchChecksumKimball2 { get; set; }

    public string TchDirtyOrgId { get; set; } = null!;

    public int TchId { get; set; }

    public int? TchInsertSubTransformationId { get; set; }

    public int TchInsertTransformationId { get; set; }

    public string TchOrgId { get; set; } = null!;

    public string? TchParCleanOrgId { get; set; }

    public string? TchParDirtyOrgId { get; set; }

    public int? TchParGid { get; set; }

    public int TchRowId { get; set; }

    public byte[] TchRowVersion { get; set; } = null!;

    public DateTime TchTimeFrom { get; set; }

    public DateTime? TchTimeTo { get; set; }

    public DateTime TchTsinsert { get; set; }

    public DateTime TchTsupdate { get; set; }

    public int? TchUpdateSubTransformationId { get; set; }

    public int TchUpdateTransformationId { get; set; }

    public int TchZrodgid { get; set; }

    public string TchNazwa { get; set; } = null!;

    public string? TchOpis { get; set; }

    public string? TchOrgAtrId { get; set; }

    public string? TchKod { get; set; }

    public virtual ICollection<FktMarszrutum> FktMarszruta { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjes { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKoszties { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual WymZrodloDanych TchZrodg { get; set; } = null!;
}
