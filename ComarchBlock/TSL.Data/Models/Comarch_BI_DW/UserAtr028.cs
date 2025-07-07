using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class UserAtr028
{
    public int? AtrybutyDataDo { get; set; }

    public int? AtrybutyDataOd { get; set; }

    public string AtrybutyDirtyOrgId { get; set; } = null!;

    public int AtrybutyId { get; set; }

    public int? AtrybutyKimball1CheckSum { get; set; }

    public int? AtrybutyKimball2CheckSum { get; set; }

    public string AtrybutyOrgId { get; set; } = null!;

    public string? AtrybutyOrgParId { get; set; }

    public string? AtrybutyParDirtyOrgId { get; set; }

    public int? AtrybutyParId { get; set; }

    public int AtrybutyRowId { get; set; }

    public byte[] AtrybutyRowVersion { get; set; } = null!;

    public int? AtrybutySubTransformationId { get; set; }

    public DateTime AtrybutyTsinsert { get; set; }

    public DateTime AtrybutyTsupdate { get; set; }

    public int AtrybutyZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? AtrybutyAktualneOrgId { get; set; }

    public string? AtrybutyAktualneOrgParId { get; set; }

    public int? AtrybutyAktywny { get; set; }

    public string? AtrybutyCastomRollup { get; set; }

    public int? AtrybutyKategoria { get; set; }

    public string? AtrybutyKonto { get; set; }

    public string? AtrybutyNazwa { get; set; }

    public string? AtrybutyOpis { get; set; }

    public int? AtrybutyOrgAtkId { get; set; }

    public string? AtrybutyOrgAtrId { get; set; }

    public int? AtrybutyPoprzednikId { get; set; }

    public int? AtrybutyRoot { get; set; }

    public int? AtrybutyTyp { get; set; }

    public int? AtrybutyTypWymiaru { get; set; }

    public int? AtrybutyWymFirma { get; set; }

    public int? AtrybutyWymTyp { get; set; }

    public int? AtrybutyFormat { get; set; }

    public int AtrybutyCzdgid { get; set; }
}
