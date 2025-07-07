using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class UserSetting
{
    public int UstUsrId { get; set; }

    public int UstSetId { get; set; }

    public string UstValue { get; set; } = null!;

    public int UstCompanyId { get; set; }

    public virtual Company UstCompany { get; set; } = null!;

    public virtual Setting UstSet { get; set; } = null!;

    public virtual User1 UstUsr { get; set; } = null!;
}
