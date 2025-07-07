using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymCzasGodzina
{
    public int? CzgDataDo { get; set; }

    public int? CzgDataOd { get; set; }

    public string? CzgDirtyOrgId { get; set; }

    public int CzgId { get; set; }

    public int? CzgKimball1CheckSum { get; set; }

    public int? CzgKimball2CheckSum { get; set; }

    public string CzgOrgId { get; set; } = null!;

    public string? CzgParCleanOrgId { get; set; }

    public string? CzgParDirtyOrgId { get; set; }

    public int? CzgParId { get; set; }

    public int? CzgRowId { get; set; }

    public byte[] CzgRowVersion { get; set; } = null!;

    public int? CzgSubTransformationId { get; set; }

    public DateTime CzgTsinsert { get; set; }

    public DateTime CzgTsupdate { get; set; }

    public int CzgZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? CzgAktualneOrgId { get; set; }

    public string? CzgAktualneOrgParId { get; set; }

    public int? CzgAktywny { get; set; }

    public int? CzgGodzina { get; set; }

    public string? CzgNazwa { get; set; }

    public string? CzgOpis { get; set; }

    public string? CzgOrgAtrId { get; set; }

    public string? CzgOrgParId { get; set; }

    public int? CzgPoprzednikId { get; set; }

    public int? CzgWymFirma { get; set; }

    public int? CzgWymTyp { get; set; }

    public virtual WymZrodloDanych CzgZrodg { get; set; } = null!;

    public virtual ICollection<FktFlotum> FktFlota { get; set; } = new List<FktFlotum>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();
}
