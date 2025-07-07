using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class User1
{
    public int UsrId { get; set; }

    public string? UsrSid { get; set; }

    public string? UsrWinAccount { get; set; }

    public string? UsrName { get; set; }

    public string? UsrSurname { get; set; }

    public string? UsrEmail { get; set; }

    public int? UsrSourceSystemId { get; set; }

    public DateTime UsrLastUpdate { get; set; }

    public int RowVer { get; set; }

    public bool UsrIsDeleted { get; set; }

    public string? UsrPhone { get; set; }

    public string? UsrPassword { get; set; }

    public string? UsrNtAccount { get; set; }

    public string? UsrLogin { get; set; }

    public bool UsrIsIntegrated { get; set; }

    public string? UsrHash { get; set; }

    public bool UsrIsActive { get; set; }

    public virtual ICollection<AccountActiveUser> AccountActiveUsers { get; set; } = new List<AccountActiveUser>();

    public virtual ICollection<AnalystInterfaceReportLayout> AnalystInterfaceReportLayouts { get; set; } = new List<AnalystInterfaceReportLayout>();

    public virtual ICollection<ApplicationUsersRole> ApplicationUsersRoles { get; set; } = new List<ApplicationUsersRole>();

    public virtual ICollection<BudgetColumn> BudgetColumns { get; set; } = new List<BudgetColumn>();

    public virtual ICollection<BudgetVersionChange> BudgetVersionChanges { get; set; } = new List<BudgetVersionChange>();

    public virtual ICollection<BudgetVersionCubesPermission> BudgetVersionCubesPermissions { get; set; } = new List<BudgetVersionCubesPermission>();

    public virtual ICollection<BudgetVersion> BudgetVersions { get; set; } = new List<BudgetVersion>();

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<CubesPermission> CubesPermissions { get; set; } = new List<CubesPermission>();

    public virtual ICollection<FormulaParameter> FormulaParameters { get; set; } = new List<FormulaParameter>();

    public virtual ICollection<MobileAccount> MobileAccounts { get; set; } = new List<MobileAccount>();

    public virtual ICollection<MobileReportsUsersSnapshot> MobileReportsUsersSnapshots { get; set; } = new List<MobileReportsUsersSnapshot>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<ReportsStore> ReportsStores { get; set; } = new List<ReportsStore>();

    public virtual ICollection<RightsFoldersUser> RightsFoldersUsers { get; set; } = new List<RightsFoldersUser>();

    public virtual ICollection<RightsReportsUser> RightsReportsUsers { get; set; } = new List<RightsReportsUser>();

    public virtual ICollection<UserFavouritesDimensionMeasure> UserFavouritesDimensionMeasures { get; set; } = new List<UserFavouritesDimensionMeasure>();

    public virtual ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();

    public virtual UserImage? UserImage { get; set; }

    public virtual ICollection<UserSetting> UserSettings { get; set; } = new List<UserSetting>();

    public virtual ICollection<UserWorkmodeHomedashboard> UserWorkmodeHomedashboards { get; set; } = new List<UserWorkmodeHomedashboard>();

    public virtual ICollection<UsersRecentlyUsed> UsersRecentlyUseds { get; set; } = new List<UsersRecentlyUsed>();

    public virtual ICollection<Group1> GruGroups { get; set; } = new List<Group1>();

    public virtual ICollection<RestrictRole> RurRoles { get; set; } = new List<RestrictRole>();
}
