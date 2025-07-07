using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class CrmdokumentyLinkiViewFullDatum
{
    public short CdlvCrmtyp { get; set; }

    public int CdlvCrmnumer { get; set; }

    public short CdlvCrmlp { get; set; }

    public short CdlvDokTyp { get; set; }

    public int CdlvDokNumer { get; set; }

    public string CdlvSkrot { get; set; } = null!;

    public int? CdlvNumer { get; set; }

    public int? CdlvRok { get; set; }

    public string? CdlvSeria { get; set; }

    public int? CdlvMiesiac { get; set; }

    public string? CdlvNrDok { get; set; }

    public string? CdlvAkronim { get; set; }

    public string? CdlvNazwa { get; set; }

    public string? CdlvMiasto { get; set; }

    public int? CdlvData { get; set; }

    public byte? CdlvTyp { get; set; }

    public decimal? CdlvKwota { get; set; }

    public decimal? CdlvNetto { get; set; }

    public int? CdlvStan { get; set; }

    public int? CdlvAktywny { get; set; }

    public byte? CdlvZaksiegowano { get; set; }

    public short? CdlvSmallInt1 { get; set; }

    public short? CdlvSmallInt2 { get; set; }

    public short? CdlvSmallInt3 { get; set; }

    public int? CdlvTinyInt1 { get; set; }

    public string? CdlvVarChar1 { get; set; }

    public decimal? CdlvNettoWal { get; set; }

    public string? CdlvWaluta { get; set; }

    public byte? CdlvNieKsiegowac { get; set; }
}
