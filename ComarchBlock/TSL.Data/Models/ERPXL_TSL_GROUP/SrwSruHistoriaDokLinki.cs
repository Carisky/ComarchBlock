using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwSruHistoriaDokLinki
{
    public int SshdlSshdid { get; set; }

    public int SshdlSruIdWyswietl { get; set; }

    public virtual SrwSruHistoriaDok SshdlSshd { get; set; } = null!;
}
