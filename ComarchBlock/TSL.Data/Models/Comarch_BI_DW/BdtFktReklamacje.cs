using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktReklamacje
{
    public int ReklId { get; set; }

    public decimal? ReklZakupuWartosc { get; set; }

    public decimal? ReklZakupuIlosc { get; set; }

    public decimal? ReklSprzedazyWartosc { get; set; }

    public decimal? ReklSprzedazyIlosc { get; set; }

    public string? ReklOrgAtrEleId { get; set; }

    public string? ReklOrgAtrNagId { get; set; }

    public int ReklAlokacjaId { get; set; }

    public decimal? ReklMczasRozpatrzenia { get; set; }

    public int? ReklTyp { get; set; }

    public decimal? ReklMczasZamkniecia { get; set; }

    public int? ReklReklEid { get; set; }

    public int? ReklCzzgid { get; set; }

    public int? ReklStrFrmGid { get; set; }

    public int? ReklPerspektywaId { get; set; }

    public int? ReklZadanieId { get; set; }

    public decimal? ReklMwartosc { get; set; }

    public decimal? ReklMilosc { get; set; }

    public int? ReklElemOrgId { get; set; }

    public int? ReklNagStatus { get; set; }

    public string? ReklOrgAtrId { get; set; }

    public DateTime ReklTsupdate { get; set; }

    public DateTime ReklTsinsert { get; set; }

    public int? ReklInsertSubTransformationId { get; set; }

    public int ReklInsertTransformationId { get; set; }

    public int? ReklUpdateSubTransformationId { get; set; }

    public int ReklUpdateTransformationId { get; set; }

    public string? ReklOpis { get; set; }

    public string ReklDirtyOrgId { get; set; } = null!;

    public string ReklOrgId { get; set; } = null!;

    public int ReklCzdid { get; set; }

    public int ReklZrodgid { get; set; }

    public int? ReklDokNumerId { get; set; }

    public int? ReklAkwId { get; set; }

    public int? ReklProdId { get; set; }

    public int? ReklZrdDokNumerId { get; set; }

    public int? ReklOpiekunId { get; set; }

    public int? ReklCechaId { get; set; }

    public int? ReklBudzetId { get; set; }

    public int? ReklKndId { get; set; }

    public int? ReklKntId { get; set; }

    public int? ReklStrPrwId { get; set; }

    public int? ReklOpeId { get; set; }

    public int ReklPreklgid { get; set; }

    public int ReklRkreid { get; set; }

    public string? ReklZrdDokNumer { get; set; }
}
