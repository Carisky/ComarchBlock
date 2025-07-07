using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ApplicationRole
{
    public int ArlId { get; set; }

    public string? ArlName { get; set; }

    public virtual ICollection<ApplicationUsersRole> ApplicationUsersRoles { get; set; } = new List<ApplicationUsersRole>();

    public virtual ICollection<ApplicationGroup> AgrGroups { get; set; } = new List<ApplicationGroup>();

    public virtual ICollection<ApplicationRight> ArrRights { get; set; } = new List<ApplicationRight>();
}
