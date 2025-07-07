using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ApplicationGroup
{
    public int GrpId { get; set; }

    public int GrpOwnerId { get; set; }

    public string GrpName { get; set; } = null!;

    public virtual ICollection<ApplicationRole> AgrRoles { get; set; } = new List<ApplicationRole>();

    public virtual ICollection<ApplicationUser> GruUsers { get; set; } = new List<ApplicationUser>();
}
