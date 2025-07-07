using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymJednostkaCzasu
{
    public int JczRowId { get; set; }

    public int JczId { get; set; }

    public int JczZrodgid { get; set; }

    public string JczOrgId { get; set; } = null!;

    public string JczDirtyOrgId { get; set; } = null!;

    public string JczNazwa { get; set; } = null!;

    public string JczOpis { get; set; } = null!;

    public string? JczParDirtyOrgId { get; set; }

    public string? JczParCleanOrgId { get; set; }

    public int? JczParGid { get; set; }

    public DateTime JczTsinsert { get; set; }

    public DateTime JczTsupdate { get; set; }

    public DateTime JczTimeFrom { get; set; }

    public DateTime? JczTimeTo { get; set; }

    public int JczChecksumKimball1 { get; set; }

    public int JczChecksumKimball2 { get; set; }

    public int JczUpdateTransformationId { get; set; }

    public int? JczUpdateSubTransformationId { get; set; }

    public int JczInsertTransformationId { get; set; }

    public int? JczInsertSubTransformationId { get; set; }

    public byte[] JczRowVersion { get; set; } = null!;

    public virtual ICollection<FktFlotum> FktFlota { get; set; } = new List<FktFlotum>();

    public virtual ICollection<FktMarszrutum> FktMarszruta { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktPrzestoje> FktPrzestojes { get; set; } = new List<FktPrzestoje>();

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWizytyElement> FktWizytyElements { get; set; } = new List<FktWizytyElement>();

    public virtual WymZrodloDanych JczZrodg { get; set; } = null!;
}
