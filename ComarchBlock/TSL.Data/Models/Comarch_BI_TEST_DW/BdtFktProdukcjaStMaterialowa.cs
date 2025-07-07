using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktProdukcjaStMaterialowa
{
    public long PsmId { get; set; }

    public int PsmAlokacjaId { get; set; }

    public int PsmMagMaterialId { get; set; }

    public int PsmOddid { get; set; }

    public int PsmEprid { get; set; }

    public int PsmBudzetId { get; set; }

    public int PsmProjektId { get; set; }

    public int? PsmRwdokNumerId { get; set; }

    public int PsmZamDokNumerId { get; set; }

    public int PsmPpcid { get; set; }

    public string? PsmOrgWymId { get; set; }

    public string? PsmOrgAtrId { get; set; }

    public decimal? PsmMkosztRzeczywisty { get; set; }

    public decimal? PsmMkosztPlan { get; set; }

    public decimal? PsmMkosztNormatyw { get; set; }

    public decimal? PsmMkosztRealizacji { get; set; }

    public decimal? PsmMiloscRzeczywista { get; set; }

    public decimal? PsmMiloscPlan { get; set; }

    public decimal? PsmMiloscNormatyw { get; set; }

    public decimal? PsmMiloscRealizacji { get; set; }

    public int PsmZrodgid { get; set; }

    public int PsmTzaid { get; set; }

    public int PsmTchid { get; set; }

    public int PsmStrFrmId { get; set; }

    public int PsmStpid { get; set; }

    public int PsmProdId { get; set; }

    public int PsmKntId { get; set; }

    public int PsmKnDid { get; set; }

    public int PsmDokNumerId { get; set; }

    public int PsmCznid { get; set; }

    public int PsmCzdkosztId { get; set; }

    public int PsmCzdid { get; set; }

    public int PsmCelId { get; set; }

    public int PsmUpdateTransformationId { get; set; }

    public int? PsmUpdateSubTransformationId { get; set; }

    public DateTime PsmTsupdate { get; set; }

    public DateTime PsmTsinsert { get; set; }

    public string PsmOrgId { get; set; } = null!;

    public string? PsmOpis { get; set; }

    public int PsmInsertTransformationId { get; set; }

    public int? PsmInsertSubTransformationId { get; set; }

    public string PsmDirtyOrgId { get; set; } = null!;

    public string? PsmRworgAtrId { get; set; }

    public int PsmJmPomId { get; set; }

    public decimal? PsmMiloscRealizacjiPom { get; set; }

    public int PsmMatGid { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02116Id { get; set; }

    public int? Wym02119Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }
}
