using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class ApplicationRight
{
    public int AprId { get; set; }

    public string? AprName { get; set; }

    public bool AprHide { get; set; }

    public virtual ICollection<ApplicationRightsTranslation> ApplicationRightsTranslations { get; set; } = new List<ApplicationRightsTranslation>();

    public virtual ICollection<ApplicationRole> ArrRoles { get; set; } = new List<ApplicationRole>();
}
