using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class OpeSkillGrupa
{
    public int OsgId { get; set; }

    public short? OsgOpeTyp { get; set; }

    public int? OsgOpeFirma { get; set; }

    public int? OsgOpeNumer { get; set; }

    public int? OsgOpeCccid { get; set; }

    public int? OsgSkillGrupa { get; set; }

    public string? OsgNazwa { get; set; }

    public virtual OpeKarty? OsgOpeNumerNavigation { get; set; }
}
