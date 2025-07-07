using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymPromocje
{
    public int? PrmDataDo { get; set; }

    public int? PrmDataOd { get; set; }

    public string PrmDirtyOrgId { get; set; } = null!;

    public int PrmId { get; set; }

    public int? PrmKimball1CheckSum { get; set; }

    public int? PrmKimball2CheckSum { get; set; }

    public string PrmOrgId { get; set; } = null!;

    public string? PrmOrgParId { get; set; }

    public string? PrmParDirtyOrgId { get; set; }

    public int? PrmParId { get; set; }

    public int PrmRowId { get; set; }

    public byte[] PrmRowVersion { get; set; } = null!;

    public int? PrmSubTransformationId { get; set; }

    public DateTime PrmTsinsert { get; set; }

    public DateTime PrmTsupdate { get; set; }

    public int PrmZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? PrmPrtId { get; set; }

    public string? PrmAktualneOrgId { get; set; }

    public string? PrmAktualneOrgParId { get; set; }

    public int? PrmAktywny { get; set; }

    public string? PrmNazwa { get; set; }

    public string? PrmOpis { get; set; }

    public string? PrmOrgAtrId { get; set; }

    public int? PrmPoprzednikId { get; set; }

    public string? PrmPrtDirtyOrgId { get; set; }

    public string? PrmStan { get; set; }

    public int? PrmWymFirma { get; set; }

    public int? PrmWymTyp { get; set; }

    public int PrmDataRozpoczeciaId { get; set; }

    public int PrmDataZakonczeniaId { get; set; }

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual WymCzasDzien PrmDataRozpoczecia { get; set; } = null!;

    public virtual WymCzasDzien PrmDataZakonczenia { get; set; } = null!;

    public virtual WymPromocjeTyp? PrmPrt { get; set; }

    public virtual WymZrodloDanych PrmZrodg { get; set; } = null!;

    public virtual ICollection<SFktRabatySprzedazy> SFktRabatySprzedazies { get; set; } = new List<SFktRabatySprzedazy>();
}
