using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Company
{
    public int ComId { get; set; }

    public string? ComName { get; set; }

    public string? ComCity { get; set; }

    public string? ComStreet { get; set; }

    public string ComNumber { get; set; } = null!;

    public int ComSubdivision { get; set; }

    public string ComNip { get; set; } = null!;

    public string? ComTel { get; set; }

    public string ComPostCode { get; set; } = null!;

    public bool? ComLoadData { get; set; }

    public string? ComModelType { get; set; }

    public bool? ComUpdateApp { get; set; }

    public string? ComAppVersion { get; set; }

    public bool? ComDwisFull { get; set; }

    public float? ComDwsize { get; set; }

    public string? ComDawSerialNumber { get; set; }

    public bool? ComIsDawVerified { get; set; }

    public string? ComPartner { get; set; }

    public bool ComIsSsoXladded { get; set; }

    public int? ComDawClientId { get; set; }

    public int? ComDawContractorId { get; set; }

    public string? ComDawPin { get; set; }

    public int? ComPartnerId { get; set; }

    public string? ComRegon { get; set; }

    public string? ComOwnerName { get; set; }

    public string? ComBankAccount { get; set; }

    public string? ComFoundedYear { get; set; }

    public string ComCountry { get; set; } = null!;

    public string? ComApartment { get; set; }

    public bool? ComIsPartner { get; set; }

    public int? ComCompanyOwnerId { get; set; }

    public string ComSubdivisionName { get; set; } = null!;

    public virtual ICollection<AccountActive> AccountActives { get; set; } = new List<AccountActive>();

    public virtual ICollection<ApplicationRole> ApplicationRoles { get; set; } = new List<ApplicationRole>();

    public virtual User1? ComCompanyOwner { get; set; }

    public virtual ICollection<CompaniesCode> CompaniesCodes { get; set; } = new List<CompaniesCode>();

    public virtual ICollection<Connection> Connections { get; set; } = new List<Connection>();

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<Group1> Group1s { get; set; } = new List<Group1>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<Setting> Settings { get; set; } = new List<Setting>();

    public virtual ICollection<SocialProfile> SocialProfiles { get; set; } = new List<SocialProfile>();

    public virtual ICollection<UserSetting> UserSettings { get; set; } = new List<UserSetting>();

    public virtual ICollection<UserWorkmodeHomedashboard> UserWorkmodeHomedashboards { get; set; } = new List<UserWorkmodeHomedashboard>();

    public virtual ICollection<UsersRecentlyUsed> UsersRecentlyUseds { get; set; } = new List<UsersRecentlyUsed>();

    public virtual ICollection<WorkMode> WorkModes { get; set; } = new List<WorkMode>();

    public virtual ICollection<DataModel> CdmDataModels { get; set; } = new List<DataModel>();
}
