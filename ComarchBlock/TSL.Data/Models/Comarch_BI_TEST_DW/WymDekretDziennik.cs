using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymDekretDziennik
{
    public int? DtdzDataDo { get; set; }

    public int? DtdzDataOd { get; set; }

    public string DtdzDirtyOrgId { get; set; } = null!;

    public int DtdzId { get; set; }

    public int? DtdzKimball1CheckSum { get; set; }

    public int? DtdzKimball2CheckSum { get; set; }

    public string DtdzOrgId { get; set; } = null!;

    public string? DtdzParCleanOrgId { get; set; }

    public string? DtdzParDirtyOrgId { get; set; }

    public int? DtdzParId { get; set; }

    public int DtdzRowId { get; set; }

    public byte[] DtdzRowVersion { get; set; } = null!;

    public int? DtdzSubTransformationId { get; set; }

    public DateTime DtdzTsinsert { get; set; }

    public DateTime DtdzTsupdate { get; set; }

    public int DtdzZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? DtdzAktualneOrgId { get; set; }

    public string? DtdzAktualneOrgParId { get; set; }

    public int? DtdzAktywny { get; set; }

    public string? DtdzNazwa { get; set; }

    public string? DtdzOpis { get; set; }

    public string? DtdzOrgAtrId { get; set; }

    public string? DtdzOrgParId { get; set; }

    public int? DtdzPoprzednikId { get; set; }

    public int? DtdzWymFirma { get; set; }

    public int? DtdzWymTyp { get; set; }

    public string? DtdzStatus { get; set; }

    public virtual WymZrodloDanych DtdzZrodg { get; set; } = null!;

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();
}
