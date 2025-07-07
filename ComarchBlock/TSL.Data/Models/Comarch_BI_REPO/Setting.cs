using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Setting
{
    public int SetId { get; set; }

    public string SetName { get; set; } = null!;

    public string SetValue { get; set; } = null!;

    public int SetCompanyId { get; set; }

    public virtual Company SetCompany { get; set; } = null!;

    public virtual ICollection<UserSetting> UserSettings { get; set; } = new List<UserSetting>();
}
