using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktWizyty
{
    public int WizId { get; set; }

    public int? WizMliczbaWizytZak { get; set; }

    public int WizMliczbaWizyt { get; set; }

    public int? WizMliczbaRealizacja { get; set; }

    public int WizAlokacjaId { get; set; }

    public int WizJczid { get; set; }

    public int WizDataZakonczeniaId { get; set; }

    public int WizDataOdrzuceniaId { get; set; }

    public decimal? WizCzasRealizacji { get; set; }

    public decimal? WizCzasPlanowany { get; set; }

    public decimal? WizMiloscDokHand { get; set; }

    public string? WizOrgAtrId { get; set; }

    public int? WizStatus { get; set; }

    public DateTime WizTsupdate { get; set; }

    public DateTime WizTsinsert { get; set; }

    public int? WizInsertSubTransformationId { get; set; }

    public int WizInsertTransformationId { get; set; }

    public int? WizUpdateSubTransformationId { get; set; }

    public int WizUpdateTransformationId { get; set; }

    public string? WizOpis { get; set; }

    public string WizDirtyOrgId { get; set; } = null!;

    public string WizOrgId { get; set; } = null!;

    public int WizCzdid { get; set; }

    public int WizZrodgid { get; set; }

    public int? WizSamId { get; set; }

    public int WizRejonId { get; set; }

    public int? WizWzwId { get; set; }

    public int? WizBudzetId { get; set; }

    public int? WizKntId { get; set; }

    public int? WizPrcId { get; set; }

    public int WizTerminZakonczeniaId { get; set; }

    public int WizTerminRozpoczeciaId { get; set; }

    public int? WizStrPrwId { get; set; }

    public int WizDlggid { get; set; }
}
