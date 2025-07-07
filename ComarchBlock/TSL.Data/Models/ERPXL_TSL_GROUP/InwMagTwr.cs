using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class InwMagTwr
{
    public int ImtInTid { get; set; }

    public int ImtMagNumer { get; set; }

    public decimal? ImtIloscMag { get; set; }

    public decimal? ImtIloscInw { get; set; }

    public decimal? ImtCena { get; set; }

    public int? ImtTpaIdMag { get; set; }

    public virtual InwTwr ImtInT { get; set; } = null!;

    public virtual Magazyny ImtMagNumerNavigation { get; set; } = null!;
}
