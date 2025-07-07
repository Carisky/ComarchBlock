using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Group1
{
    public int GrpId { get; set; }

    public int GrpOwnerId { get; set; }

    public string GrpName { get; set; } = null!;

    public int GrpCompanyId { get; set; }

    public int GrpGroupType { get; set; }

    public virtual Company GrpCompany { get; set; } = null!;

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<RightsFoldersGroup> RightsFoldersGroups { get; set; } = new List<RightsFoldersGroup>();

    public virtual ICollection<RightsReportsGroup> RightsReportsGroups { get; set; } = new List<RightsReportsGroup>();

    public virtual ICollection<ApplicationRole> AgrRoles { get; set; } = new List<ApplicationRole>();

    public virtual ICollection<User1> GruUsers { get; set; } = new List<User1>();

    public virtual ICollection<RestrictRole> RgrRoles { get; set; } = new List<RestrictRole>();
}
