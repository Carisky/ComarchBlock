using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class ApplicationRole
{
    public int ArlId { get; set; }

    public string? ArlName { get; set; }

    public int ArlCompanyId { get; set; }

    public int ArlRoleType { get; set; }

    public virtual ICollection<ApplicationUsersRole> ApplicationUsersRoles { get; set; } = new List<ApplicationUsersRole>();

    public virtual Company ArlCompany { get; set; } = null!;

    public virtual ICollection<Group1> AgrGroups { get; set; } = new List<Group1>();

    public virtual ICollection<ApplicationRight> ArrRights { get; set; } = new List<ApplicationRight>();
}
