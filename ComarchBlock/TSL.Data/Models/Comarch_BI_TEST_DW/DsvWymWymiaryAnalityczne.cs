using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymWymiaryAnalityczne
{
    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? WymAktualneOrgId { get; set; }

    public string? WymAktualneOrgParId { get; set; }

    public int? WymAktywny { get; set; }

    public string? WymCastomRollup { get; set; }

    public int? WymDataDo { get; set; }

    public int? WymDataOd { get; set; }

    public string WymDirtyOrgId { get; set; } = null!;

    public int WymId { get; set; }

    public int? WymKategoria { get; set; }

    public int? WymKimball1CheckSum { get; set; }

    public int? WymKimball2CheckSum { get; set; }

    public string? WymKonto { get; set; }

    public string? WymNazwa { get; set; }

    public string? WymNazwaPoziomu { get; set; }

    public string? WymOpis { get; set; }

    public int? WymOrgAtkId { get; set; }

    public string? WymOrgAtrId { get; set; }

    public string WymOrgId { get; set; } = null!;

    public string? WymOrgParId { get; set; }

    public string? WymParDirtyOrgId { get; set; }

    public int? WymParId { get; set; }

    public int? WymPoprzednikId { get; set; }

    public int? WymRoot { get; set; }

    public int? WymRowId { get; set; }

    public byte[] WymRowVersion { get; set; } = null!;

    public int? WymSubTransformationId { get; set; }

    public int? WymTmpParId { get; set; }

    public DateTime WymTsinsert { get; set; }

    public DateTime WymTsupdate { get; set; }

    public int? WymTyp { get; set; }

    public int? WymTypWymiaru { get; set; }

    public int? WymWymFirma { get; set; }

    public int? WymWymTyp { get; set; }

    public int WymZrodgid { get; set; }
}
