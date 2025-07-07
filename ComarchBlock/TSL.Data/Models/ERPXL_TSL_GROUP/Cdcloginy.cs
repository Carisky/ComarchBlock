using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Cdcloginy
{
    public int CdclId { get; set; }

    public int? CdclBnkNumer { get; set; }

    public int? CdclOpeNumer { get; set; }

    public string? CdclLogin { get; set; }

    public string? CdclLoginTyp { get; set; }

    public virtual Banki? CdclBnkNumerNavigation { get; set; }

    public virtual OpeKarty? CdclOpeNumerNavigation { get; set; }
}
