using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class CompaniesCode
{
    public int CcoCompanyId { get; set; }

    public int CcoCodeId { get; set; }

    public DateTime CcoUseDate { get; set; }

    public virtual PromotionCode CcoCode { get; set; } = null!;

    public virtual Company CcoCompany { get; set; } = null!;
}
