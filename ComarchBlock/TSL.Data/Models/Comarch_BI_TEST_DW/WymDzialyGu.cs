using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymDzialyGu
{
    public int DziRowId { get; set; }

    public int DziId { get; set; }

    public int DziZrodgid { get; set; }

    public int DziSekid { get; set; }

    public string DziOrgId { get; set; } = null!;

    public string DziDirtyOrgId { get; set; } = null!;

    public string DziNazwa { get; set; } = null!;

    public string? DziOpis { get; set; }

    public string? DziParDirtyOrgId { get; set; }

    public string? DziParOrgId { get; set; }

    public int? DziParGid { get; set; }

    public DateTime DziTsinsert { get; set; }

    public DateTime DziTsupdate { get; set; }

    public DateTime DziTimeFrom { get; set; }

    public DateTime? DziTimeTo { get; set; }

    public int DziChecksumKimball1 { get; set; }

    public int DziChecksumKimball2 { get; set; }

    public int DziUpdateTransformationId { get; set; }

    public int? DziUpdateSubTransformationId { get; set; }

    public int DziInsertTransformationId { get; set; }

    public int? DziInsertSubTransformationId { get; set; }

    public byte[] DziRowVersion { get; set; } = null!;

    public virtual WymSekcjeGu DziSek { get; set; } = null!;

    public virtual WymZrodloDanych DziZrodg { get; set; } = null!;

    public virtual ICollection<FktJgospodarczeGu> FktJgospodarczeGus { get; set; } = new List<FktJgospodarczeGu>();

    public virtual ICollection<FktLudnoscGu> FktLudnoscGus { get; set; } = new List<FktLudnoscGu>();
}
