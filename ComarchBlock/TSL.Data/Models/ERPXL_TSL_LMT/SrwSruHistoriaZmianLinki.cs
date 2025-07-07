using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrwSruHistoriaZmianLinki
{
    public int SshzlSshzid { get; set; }

    public int SshzlSruIdWyswietl { get; set; }

    public virtual SrwSruHistoriaZmian SshzlSshz { get; set; } = null!;
}
