using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class RestrictRole
{
    public int RrlId { get; set; }

    public string? RrlName { get; set; }

    public int RrlCompanyId { get; set; }

    public string RrlXmlstring { get; set; } = null!;

    public int? RrlAccountActiveId { get; set; }

    public virtual ICollection<Group1> RgrGroups { get; set; } = new List<Group1>();

    public virtual ICollection<User1> RurUsers { get; set; } = new List<User1>();
}
