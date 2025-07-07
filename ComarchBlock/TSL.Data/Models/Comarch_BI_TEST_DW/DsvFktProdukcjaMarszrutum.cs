using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktProdukcjaMarszrutum
{
    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int PmaAlokacjaId { get; set; }

    public int PmaBudzetId { get; set; }

    public int PmaCzdid { get; set; }

    public int PmaCzdzakId { get; set; }

    public int PmaCznid { get; set; }

    public int PmaDataDokumentuId { get; set; }

    public string PmaDirtyOrgId { get; set; } = null!;

    public int PmaDokNumerId { get; set; }

    public int? PmaDokRealizacjaId { get; set; }

    public int PmaEprid { get; set; }

    public long PmaId { get; set; }

    public int? PmaInsertSubTransformationId { get; set; }

    public int PmaInsertTransformationId { get; set; }

    public int? PmaJczid { get; set; }

    public int PmaKnDid { get; set; }

    public int PmaKntId { get; set; }

    public decimal PmaMczasNormatyw { get; set; }

    public decimal? PmaMczasPlan { get; set; }

    public decimal? PmaMczasPlanDo { get; set; }

    public decimal? PmaMczasPlanOd { get; set; }

    public decimal PmaMczasRozliczNorma { get; set; }

    public decimal PmaMczasRozliczPlan { get; set; }

    public decimal PmaMczasRozliczRzecz { get; set; }

    public decimal? PmaMczasRzeczywiste { get; set; }

    public decimal? PmaMczasRzeczywisteDo { get; set; }

    public decimal? PmaMczasRzeczywisteOd { get; set; }

    public decimal PmaMiloscNormatyw { get; set; }

    public decimal PmaMiloscPlan { get; set; }

    public decimal PmaMiloscRzeczywista { get; set; }

    public decimal PmaMkosztyNormatyw { get; set; }

    public decimal PmaMkosztyPlan { get; set; }

    public decimal PmaMkosztyRzeczywiste { get; set; }

    public int PmaObpid { get; set; }

    public int PmaOddid { get; set; }

    public string? PmaOpis { get; set; }

    public string? PmaOrgAtrId { get; set; }

    public string PmaOrgId { get; set; } = null!;

    public string? PmaOrgWymId { get; set; }

    public int PmaProdId { get; set; }

    public int PmaProjektId { get; set; }

    public int? PmaRodzKosztId { get; set; }

    public int PmaStpid { get; set; }

    public int PmaStrFrmId { get; set; }

    public int PmaTchid { get; set; }

    public DateTime PmaTsinsert { get; set; }

    public DateTime PmaTsupdate { get; set; }

    public int? PmaUpdateSubTransformationId { get; set; }

    public int PmaUpdateTransformationId { get; set; }

    public int PmaZamDokNumerId { get; set; }

    public int PmaZrodgid { get; set; }
}
