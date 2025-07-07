using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymCzasMiesiac
{
    public int? CzmAktualneOrgId { get; set; }

    public int? CzmAktualneOrgParId { get; set; }

    public int? CzmAktywny { get; set; }

    public int? CzmCzrid { get; set; }

    public int? CzmDataDo { get; set; }

    public int? CzmDataOd { get; set; }

    public string? CzmDirtyOrgId { get; set; }

    public int CzmId { get; set; }

    public int? CzmKimball1CheckSum { get; set; }

    public int? CzmKimball2CheckSum { get; set; }

    public string? CzmKodMiesiaca { get; set; }

    public string? CzmNazwa { get; set; }

    public string? CzmNazwaKwartalu { get; set; }

    public string? CzmNazwaMiesiaca { get; set; }

    public int? CzmNrKwartalu { get; set; }

    public int? CzmNrMiesiaca { get; set; }

    public string? CzmOpis { get; set; }

    public string? CzmOrgAtrId { get; set; }

    public int? CzmOrgId { get; set; }

    public int? CzmOrgParId { get; set; }

    public string? CzmParCleanOrgId { get; set; }

    public string? CzmParDirtyOrgId { get; set; }

    public int? CzmParId { get; set; }

    public int? CzmPoprzednikId { get; set; }

    public string? CzmRok { get; set; }

    public int? CzmRowId { get; set; }

    public byte[] CzmRowVersion { get; set; } = null!;

    public int? CzmSubTransformationId { get; set; }

    public DateTime CzmTsinsert { get; set; }

    public DateTime CzmTsupdate { get; set; }

    public int? CzmWymFirma { get; set; }

    public int? CzmWymTyp { get; set; }

    public int CzmZrodgid { get; set; }

    public int? KwartalKey { get; set; }

    public string? KwartalName { get; set; }

    public string? MiesiacName { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
