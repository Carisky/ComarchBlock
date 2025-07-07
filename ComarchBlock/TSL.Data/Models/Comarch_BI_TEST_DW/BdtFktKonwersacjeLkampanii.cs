using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktKonwersacjeLkampanii
{
    public int KamId { get; set; }

    public int KamCrmetapZrdId { get; set; }

    public int KamCrmkampZrdId { get; set; }

    public int KamTypKntEtapId { get; set; }

    public int KamAlokacjaId { get; set; }

    public int? KamKdzId { get; set; }

    public decimal? KamMprzychodO { get; set; }

    public string? KamOrgAtrId { get; set; }

    public int KamRejonId { get; set; }

    public int KamBudzetId { get; set; }

    public int KamOpeDid { get; set; }

    public int KamObkId { get; set; }

    public int KamTyp { get; set; }

    public int? KamDataRozpoczeciaKntId { get; set; }

    public int? KamDataZakonczeniaKntId { get; set; }

    public int KamCzdid { get; set; }

    public string? KamKnwOrgId { get; set; }

    public decimal? KamMczasPodjecia { get; set; }

    public decimal? KamMsprzedaz { get; set; }

    public decimal? KamMliczbaInKampNakt { get; set; }

    public decimal? KamMliczbaInKampAkt { get; set; }

    public int KamSktId { get; set; }

    public int KamKtkId { get; set; }

    public int KamOpeId { get; set; }

    public int KamOsoId { get; set; }

    public int KamAkwId { get; set; }

    public decimal? KamMszansaP { get; set; }

    public decimal? KamMiloscR { get; set; }

    public decimal? KamMiloscP { get; set; }

    public decimal? KamMkosztR { get; set; }

    public decimal? KamMkosztP { get; set; }

    public decimal? KamMprzychodR { get; set; }

    public decimal? KamMprzychodP { get; set; }

    public DateTime KamTsupdate { get; set; }

    public DateTime KamTsinsert { get; set; }

    public int? KamInsertSubTransformationId { get; set; }

    public int KamInsertTransformationId { get; set; }

    public int? KamUpdateSubTransformationId { get; set; }

    public int KamUpdateTransformationId { get; set; }

    public string? KamOpis { get; set; }

    public string KamDirtyOrgId { get; set; } = null!;

    public string KamCleanOrgId { get; set; } = null!;

    public int KamZrodgid { get; set; }

    public int KamKntId { get; set; }

    public int KamCrmkampId { get; set; }

    public int KamDokNumerId { get; set; }

    public int KamCrmetapId { get; set; }

    public int? KamDataOdId { get; set; }

    public int? KamDataDoId { get; set; }
}
