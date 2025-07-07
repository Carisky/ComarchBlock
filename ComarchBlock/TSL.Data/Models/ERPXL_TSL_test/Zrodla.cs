using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Zrodla
{
    public short ZroTrntyp { get; set; }

    public int ZroTrnfirma { get; set; }

    public int ZroTrnnumer { get; set; }

    public short ZroTrnlp { get; set; }

    public short ZroDttyp { get; set; }

    public int ZroDtfirma { get; set; }

    public int ZroDtnumer { get; set; }

    public short ZroDtlp { get; set; }

    public int? ZroDataOddzialu { get; set; }

    public int? ZroDataCentrali { get; set; }
}
