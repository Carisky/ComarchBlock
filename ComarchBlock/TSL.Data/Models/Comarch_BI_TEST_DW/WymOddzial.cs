using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymOddzial
{
    public int OddChecksumKimball1 { get; set; }

    public int OddChecksumKimball2 { get; set; }

    public string OddDirtyOrgId { get; set; } = null!;

    public int OddId { get; set; }

    public int? OddInsertSubTransformationId { get; set; }

    public int OddInsertTransformationId { get; set; }

    public string OddOrgId { get; set; } = null!;

    public string? OddParCleanOrgId { get; set; }

    public string? OddParDirtyOrgId { get; set; }

    public int? OddParGid { get; set; }

    public int OddRowId { get; set; }

    public byte[] OddRowVersion { get; set; } = null!;

    public DateTime OddTimeFrom { get; set; }

    public DateTime? OddTimeTo { get; set; }

    public DateTime OddTsinsert { get; set; }

    public DateTime OddTsupdate { get; set; }

    public int? OddUpdateSubTransformationId { get; set; }

    public int OddUpdateTransformationId { get; set; }

    public int OddZrodgid { get; set; }

    public string OddNazwa { get; set; } = null!;

    public string OddOpis { get; set; } = null!;

    public virtual ICollection<FktMarszrutum> FktMarszrutumPmrszOddgniazdoGs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPmrszOddzasobGs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktMarszrutum> FktMarszrutumPmrszOddzpgs { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjes { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKoszties { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPrzestoje> FktPrzestojes { get; set; } = new List<FktPrzestoje>();

    public virtual WymZrodloDanych OddZrodg { get; set; } = null!;
}
