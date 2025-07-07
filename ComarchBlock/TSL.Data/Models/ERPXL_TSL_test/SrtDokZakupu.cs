using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SrtDokZakupu
{
    public int SdzSrtNumer { get; set; }

    public short SdzDokTyp { get; set; }

    public int SdzDokNumer { get; set; }

    public byte? SdzStronaPowiazania { get; set; }

    public virtual SrtKarty SdzSrtNumerNavigation { get; set; } = null!;
}
