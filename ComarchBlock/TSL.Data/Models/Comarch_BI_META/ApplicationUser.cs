using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ApplicationUser
{
    public int UsrId { get; set; }

    public string? UsrSid { get; set; }

    public string UsrWinAccount { get; set; } = null!;

    public string? UsrPasswordHash { get; set; }

    public string? UsrName { get; set; }

    public string? UsrSurname { get; set; }

    public string? UsrEmail { get; set; }

    public DateTime UsrLastUpdate { get; set; }

    public int RowVer { get; set; }

    public bool? UsrIsDeleted { get; set; }

    public bool? UsrIsDomain { get; set; }

    public virtual ICollection<ApplicationUsersRole> ApplicationUsersRoles { get; set; } = new List<ApplicationUsersRole>();

    public virtual ICollection<ApplicationUsersTable> ApplicationUsersTables { get; set; } = new List<ApplicationUsersTable>();

    public virtual ICollection<CorrectionRule> CorrectionRules { get; set; } = new List<CorrectionRule>();

    public virtual ICollection<FieldSettingsForUser> FieldSettingsForUsers { get; set; } = new List<FieldSettingsForUser>();

    public virtual ICollection<ApplicationGroup> GruGroups { get; set; } = new List<ApplicationGroup>();
}
