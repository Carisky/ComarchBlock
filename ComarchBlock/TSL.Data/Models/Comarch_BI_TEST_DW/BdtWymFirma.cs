using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymFirma
{
    public int FirmaId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? FirmaRowId { get; set; }

    public string? FirmaNip { get; set; }

    public int? FirmaWymTyp { get; set; }

    public int? FirmaWymFirma { get; set; }

    public int? FirmaPoprzednikId { get; set; }

    public string? FirmaPoczta { get; set; }

    public string? FirmaOrgParId { get; set; }

    public string? FirmaOrgAtrId { get; set; }

    public string? FirmaOpis { get; set; }

    public string? FirmaNazwa { get; set; }

    public string? FirmaKodPocztowy { get; set; }

    public int? FirmaAktywny { get; set; }

    public string? FirmaAktualneOrgParId { get; set; }

    public string? FirmaAktualneOrgId { get; set; }

    public string? FirmaAdres { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int FirmaZrodgid { get; set; }

    public DateTime FirmaTsupdate { get; set; }

    public DateTime FirmaTsinsert { get; set; }

    public int? FirmaSubTransformationId { get; set; }

    public byte[] FirmaRowVersion { get; set; } = null!;

    public int? FirmaParId { get; set; }

    public string? FirmaParDirtyOrgId { get; set; }

    public string? FirmaParCleanOrgId { get; set; }

    public string FirmaOrgId { get; set; } = null!;

    public int? FirmaKimball2CheckSum { get; set; }

    public int? FirmaKimball1CheckSum { get; set; }

    public string FirmaDirtyOrgId { get; set; } = null!;

    public int? FirmaDataOd { get; set; }

    public int? FirmaDataDo { get; set; }
}
