using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktZamowieniaRmagLpozycji
{
    public int ZrmAkwId { get; set; }

    public int ZrmAlokacjaId { get; set; }

    public int ZrmBudzetId { get; set; }

    public int ZrmCechyId { get; set; }

    public int ZrmCzdfaktId { get; set; }

    public int ZrmCzdid { get; set; }

    public int ZrmCzdplanId { get; set; }

    public string ZrmDirtyOrgId { get; set; } = null!;

    public int ZrmDokElemId { get; set; }

    public int ZrmDokNumerId { get; set; }

    public int ZrmDokNumerZamId { get; set; }

    public long ZrmId { get; set; }

    public int? ZrmInsertSubTransformationId { get; set; }

    public int ZrmInsertTransformationId { get; set; }

    public int ZrmJmId { get; set; }

    public int ZrmJmPid { get; set; }

    public int? ZrmKierunek { get; set; }

    public int ZrmKnDid { get; set; }

    public int ZrmKntId { get; set; }

    public int ZrmLokGid { get; set; }

    public int ZrmMagId { get; set; }

    public decimal? ZrmMilosc { get; set; }

    public decimal? ZrmMiloscJmP { get; set; }

    public decimal? ZrmMiloscRealizacji { get; set; }

    public decimal? ZrmMiloscRealizacjiJmP { get; set; }

    public decimal? ZrmMwaga { get; set; }

    public int ZrmOpegid { get; set; }

    public int ZrmOpemgid { get; set; }

    public int ZrmOpewgid { get; set; }

    public int ZrmOpezgid { get; set; }

    public int ZrmOpiekunId { get; set; }

    public string? ZrmOpis { get; set; }

    public string? ZrmOrgAtrId { get; set; }

    public string ZrmOrgId { get; set; } = null!;

    public string? ZrmOrgWymId { get; set; }

    public int ZrmPlatId { get; set; }

    public int ZrmPrcId { get; set; }

    public int ZrmPrmgid { get; set; }

    public int ZrmProdId { get; set; }

    public int ZrmProduktPozycjeDokId { get; set; }

    public int ZrmProjektGid { get; set; }

    public int ZrmRejonId { get; set; }

    public int ZrmStrFrmId { get; set; }

    public DateTime ZrmTsinsert { get; set; }

    public DateTime ZrmTsupdate { get; set; }

    public int? ZrmTypKwoty { get; set; }

    public int? ZrmTzamId { get; set; }

    public int? ZrmUpdateSubTransformationId { get; set; }

    public int ZrmUpdateTransformationId { get; set; }

    public int ZrmWalutaId { get; set; }

    public int? ZrmWymTyp { get; set; }

    public int ZrmZrodgid { get; set; }
}
