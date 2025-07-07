using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymMagazyn
{
    public string? Gid { get; set; }

    public string? MagAdres { get; set; }

    public string? MagAktualneOrgId { get; set; }

    public string? MagAktualneOrgParId { get; set; }

    public int? MagAktywny { get; set; }

    public string? MagAnalityka { get; set; }

    public decimal? MagAnalizaA { get; set; }

    public byte? MagAnalizaAbcxyz { get; set; }

    public decimal? MagAnalizaB { get; set; }

    public decimal? MagAnalizaC { get; set; }

    public decimal? MagAnalizaX { get; set; }

    public decimal? MagAnalizaY { get; set; }

    public decimal? MagAnalizaZ { get; set; }

    public int? MagDataDo { get; set; }

    public int? MagDataOd { get; set; }

    public string MagDirtyOrgId { get; set; } = null!;

    public int MagId { get; set; }

    public int? MagKimball1CheckSum { get; set; }

    public int? MagKimball2CheckSum { get; set; }

    public string? MagKodPocztowy { get; set; }

    public string? MagMiasto { get; set; }

    public string? MagNazwa { get; set; }

    public int? MagOdpowiedzialnyId { get; set; }

    public string? MagOpis { get; set; }

    public string? MagOrgAtrId { get; set; }

    public string MagOrgId { get; set; } = null!;

    public string? MagOrgParId { get; set; }

    public string? MagParCleanOrgId { get; set; }

    public string? MagParDirtyOrgId { get; set; }

    public int? MagParId { get; set; }

    public decimal? MagPojemnosc { get; set; }

    public int? MagPoprzednikId { get; set; }

    public string? MagRodzaj { get; set; }

    public int? MagRowId { get; set; }

    public byte[] MagRowVersion { get; set; } = null!;

    public int? MagSubTransformationId { get; set; }

    public string? MagSymbol { get; set; }

    public DateTime MagTsinsert { get; set; }

    public DateTime MagTsupdate { get; set; }

    public string? MagTyp { get; set; }

    public int? MagWymFirma { get; set; }

    public int? MagWymTyp { get; set; }

    public int MagZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? MagAktywnyOpis { get; set; }

    public string? MagOddzialowy { get; set; }

    public string? MagWewnetrzny { get; set; }
}
