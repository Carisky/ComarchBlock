using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Report
{
    public int RepId { get; set; }

    public int RepType { get; set; }

    public string? RepServerName { get; set; }

    public string? RepCatalogName { get; set; }

    public string? RepCubeName { get; set; }

    public DateTime RepCreatedOn { get; set; }

    public DateTime? RepModifiedOn { get; set; }

    public string? RepDescription { get; set; }

    public int? RepViewType { get; set; }

    public int RepOwnerId { get; set; }

    public bool? RepUseDefaultConnection { get; set; }

    public string? RepLanguage { get; set; }

    public int? RepWebServicePort { get; set; }

    public byte[]? RepSnapshot { get; set; }

    public int? RepPredefinedReport { get; set; }

    public bool RepIsPredefinedReport { get; set; }

    public bool RepUseInMemory { get; set; }

    public string? RepStdReportId { get; set; }

    public int? RepStdReportVersion { get; set; }

    public int? RepStdReportHash { get; set; }

    public int RepCompanyId { get; set; }

    public string? RepData { get; set; }

    public byte[] RepTimestamp { get; set; } = null!;

    public bool RepIsStdReport { get; set; }

    public bool RepIsOpenInTime { get; set; }

    public int RepSourceDbType { get; set; }

    public string? RepMetadata { get; set; }

    public string? RepOrgId { get; set; }

    public virtual ICollection<AnalystInterfaceReportLayout> AnalystInterfaceReportLayouts { get; set; } = new List<AnalystInterfaceReportLayout>();

    public virtual ICollection<Link> Links { get; set; } = new List<Link>();

    public virtual ICollection<MobileReportsUsersSnapshot> MobileReportsUsersSnapshots { get; set; } = new List<MobileReportsUsersSnapshot>();

    public virtual Company RepCompany { get; set; } = null!;

    public virtual ICollection<ReportParameter> ReportParameters { get; set; } = new List<ReportParameter>();

    public virtual ICollection<ReportsDatum> ReportsData { get; set; } = new List<ReportsDatum>();

    public virtual ICollection<ReportsStore> ReportsStores { get; set; } = new List<ReportsStore>();

    public virtual ICollection<RightsReportsGroup> RightsReportsGroups { get; set; } = new List<RightsReportsGroup>();

    public virtual ICollection<RightsReportsUser> RightsReportsUsers { get; set; } = new List<RightsReportsUser>();

    public virtual ICollection<SubscriptionsReport> SubscriptionsReports { get; set; } = new List<SubscriptionsReport>();

    public virtual ICollection<UserWorkmodeHomedashboard> UserWorkmodeHomedashboards { get; set; } = new List<UserWorkmodeHomedashboard>();

    public virtual ICollection<UsersRecentlyUsed> UsersRecentlyUseds { get; set; } = new List<UsersRecentlyUsed>();

    public virtual ICollection<Context> CtrContexts { get; set; } = new List<Context>();

    public virtual ICollection<Report> DbrDashboards { get; set; } = new List<Report>();

    public virtual ICollection<Report> DbrReports { get; set; } = new List<Report>();

    public virtual ICollection<DataModel> DmrDms { get; set; } = new List<DataModel>();
}
