using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymPracownik
{
    public int PrcId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? PrcRowId { get; set; }

    public string? Gid { get; set; }

    public string? PrcPlec { get; set; }

    public DateTime? PrcDataUrodzenia { get; set; }

    public int? FaktyPrc { get; set; }

    public int? FaktyOpiekunspinacz { get; set; }

    public int? FaktyPracownik { get; set; }

    public int? PrcWymTyp { get; set; }

    public int? PrcWymFirma { get; set; }

    public string? PrcTelefonWew { get; set; }

    public string? PrcTelefonKom { get; set; }

    public string? PrcTelefonDomowy { get; set; }

    public string? PrcTelefon { get; set; }

    public string? PrcSymbol { get; set; }

    public int? PrcPoprzednikId { get; set; }

    public string? PrcOrgParId { get; set; }

    public string? PrcOrgAtrId { get; set; }

    public string? PrcOpis { get; set; }

    public string? PrcNazwisko { get; set; }

    public string PrcNazwa { get; set; } = null!;

    public string? PrcMiasto { get; set; }

    public string? PrcKodPocztowy { get; set; }

    public string? PrcEmail { get; set; }

    public string? PrcAktualneOrgParId { get; set; }

    public string? PrcAktualneOrgId { get; set; }

    public string? PrcAdres { get; set; }

    public int? FaktyOpiekun { get; set; }

    public int? PrcStrFirmyId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int PrcZrodgid { get; set; }

    public DateTime PrcTsupdate { get; set; }

    public DateTime PrcTsinsert { get; set; }

    public int? PrcSubTransformationId { get; set; }

    public byte[] PrcRowVersion { get; set; } = null!;

    public int? PrcParId { get; set; }

    public string? PrcParDirtyOrgId { get; set; }

    public string? PrcParCleanOrgId { get; set; }

    public string PrcOrgId { get; set; } = null!;

    public int? PrcKimball2CheckSum { get; set; }

    public int? PrcKimball1CheckSum { get; set; }

    public string PrcDirtyOrgId { get; set; } = null!;

    public int? PrcDataOd { get; set; }

    public int? PrcDataDo { get; set; }

    public int? PrcOptimaId { get; set; }

    public string? PrcAktywny { get; set; }
}
