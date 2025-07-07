using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class WorkMode
{
    public int WorId { get; set; }

    public string WorName { get; set; } = null!;

    public int WorCountDay { get; set; }

    public string? WorStandardReportsPath { get; set; }

    public int WorCompanyId { get; set; }

    public int? WorDataModelsDefinitionId { get; set; }

    public bool? WorIsPaymentWorkMode { get; set; }

    public bool? WorIsPerUserPayment { get; set; }

    public bool? WorIsPerMonthPayment { get; set; }

    public bool? WorIsMultiCompany { get; set; }

    public bool? WorHasOwnDw { get; set; }

    public string? WorDemoReportsPath { get; set; }

    public virtual ICollection<AccountActive> AccountActives { get; set; } = new List<AccountActive>();

    public virtual ICollection<PromotionCodesWorkMode> PromotionCodesWorkModes { get; set; } = new List<PromotionCodesWorkMode>();

    public virtual ICollection<UserInvitationToCompany> UserInvitationToCompanies { get; set; } = new List<UserInvitationToCompany>();

    public virtual ICollection<UserWorkmodeHomedashboard> UserWorkmodeHomedashboards { get; set; } = new List<UserWorkmodeHomedashboard>();

    public virtual Company WorCompany { get; set; } = null!;

    public virtual DataModelsDefinition? WorDataModelsDefinition { get; set; }
}
