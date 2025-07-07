using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class PromotionCode
{
    public int PcoId { get; set; }

    public string PcoCode { get; set; } = null!;

    public DateTime PcoCreateDate { get; set; }

    public DateTime PcoExpirationDate { get; set; }

    public int PcoMonths { get; set; }

    public double PcoDiscount { get; set; }

    public int PcoAllUsages { get; set; }

    public int PcoAvailableUsages { get; set; }

    public int PcoFirstUsage { get; set; }

    public bool PcoSingleUse { get; set; }

    public int PcoWorkMode { get; set; }

    public int? PcoPartnerId { get; set; }

    public int PcoUsers { get; set; }

    public virtual ICollection<CompaniesCode> CompaniesCodes { get; set; } = new List<CompaniesCode>();

    public virtual ICollection<PromotionCodesWorkMode> PromotionCodesWorkModes { get; set; } = new List<PromotionCodesWorkMode>();
}
