using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktTransportLdokumentowPaczek
{
    public int TrsCzdwysId { get; set; }

    public long TrsId { get; set; }

    public int TrsZrodgid { get; set; }

    public int TrsCzdid { get; set; }

    public string TrsOrgId { get; set; } = null!;

    public string TrsDirtyOrgId { get; set; } = null!;

    public string? TrsOpis { get; set; }

    public int TrsUpdateTransformationId { get; set; }

    public int? TrsUpdateSubTransformationId { get; set; }

    public int TrsInsertTransformationId { get; set; }

    public int? TrsInsertSubTransformationId { get; set; }

    public DateTime TrsTsinsert { get; set; }

    public DateTime TrsTsupdate { get; set; }

    public int TrsCzddstOdId { get; set; }

    public int TrsCzddstDoId { get; set; }

    public int TrsPrcId { get; set; }

    public int TrsKnSid { get; set; }

    public int TrsTrasaId { get; set; }

    public int TrsDokNumerWysid { get; set; }

    public int TrsDokNumerId { get; set; }

    public int? TrsFlagaKosztu { get; set; }

    public decimal? TrsObjetosc { get; set; }

    public decimal? TrsWagaBrutto { get; set; }

    public decimal? TrsMdlugoscTrasy { get; set; }

    public int TrsSamId { get; set; }

    public decimal? TrsMkoszt { get; set; }

    public int TrsBudzetId { get; set; }

    public string? TrsOrgAtrId { get; set; }

    public decimal? TrsMdlugoscTrasyRozbita { get; set; }

    public int? TrsObszar { get; set; }

    public int TrsAlokacjaId { get; set; }

    public string? TrsOrgAtrNagIdwys { get; set; }

    public string? TrsOrgAtrNagIdwyp { get; set; }

    public decimal? TrsMwysNetto { get; set; }

    public decimal? TrsMwysBrutto { get; set; }

    public int? TrsStrPrwId { get; set; }

    public decimal? TrsWagaNetto { get; set; }

    public decimal? TrsMiloscPaczek { get; set; }

    public int TrsDokZwiazanyId { get; set; }

    public int TrsKntDokZwiazanyId { get; set; }

    public decimal? TrsMiloscTowaru { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }
}
