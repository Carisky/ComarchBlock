using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymCzasTrwaniaTypTel
{
    public int? CztrwaniaTypDataDo { get; set; }

    public int? CztrwaniaTypDataOd { get; set; }

    public string CztrwaniaTypDirtyOrgId { get; set; } = null!;

    public int CztrwaniaTypId { get; set; }

    public int? CztrwaniaTypKimball1CheckSum { get; set; }

    public int? CztrwaniaTypKimball2CheckSum { get; set; }

    public string CztrwaniaTypOrgId { get; set; } = null!;

    public string? CztrwaniaTypOrgParId { get; set; }

    public string? CztrwaniaTypParDirtyOrgId { get; set; }

    public int? CztrwaniaTypParId { get; set; }

    public int CztrwaniaTypRowId { get; set; }

    public byte[] CztrwaniaTypRowVersion { get; set; } = null!;

    public int? CztrwaniaTypSubTransformationId { get; set; }

    public DateTime CztrwaniaTypTsinsert { get; set; }

    public DateTime CztrwaniaTypTsupdate { get; set; }

    public int CztrwaniaTypZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? CztrwaniaTypAktualneOrgId { get; set; }

    public string? CztrwaniaTypAktualneOrgParId { get; set; }

    public int? CztrwaniaTypAktywny { get; set; }

    public string? CztrwaniaTypNazwa { get; set; }

    public string? CztrwaniaTypOpis { get; set; }

    public string? CztrwaniaTypOrgAtrId { get; set; }

    public int? CztrwaniaTypPoprzednikId { get; set; }

    public int? CztrwaniaTypWymFirma { get; set; }

    public int? CztrwaniaTypWymTyp { get; set; }

    public virtual WymZrodloDanych CztrwaniaTypZrodg { get; set; } = null!;

    public virtual ICollection<WymCzasTrwaniaTel> WymCzasTrwaniaTels { get; set; } = new List<WymCzasTrwaniaTel>();
}
