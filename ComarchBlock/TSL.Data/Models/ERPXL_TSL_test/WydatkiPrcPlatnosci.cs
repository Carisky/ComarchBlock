using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class WydatkiPrcPlatnosci
{
    public int WppWprid { get; set; }

    public short? WppDlgtrptyp { get; set; }

    public int? WppDlgtrpfirma { get; set; }

    public int? WppDlgtrpnumer { get; set; }

    public short WppDlgtrplp { get; set; }

    public short? WppDlgtrpprzeciwTyp { get; set; }

    public int? WppDlgtrpprzeciwFirma { get; set; }

    public int? WppDlgtrpprzeciwNumer { get; set; }

    public short? WppDlgtrpprzeciwLp { get; set; }

    public short? WppDokTrptyp { get; set; }

    public int? WppDokTrpfirma { get; set; }

    public int? WppDokTrpnumer { get; set; }

    public short? WppDokTrplp { get; set; }

    public virtual TraPlat? TraPlat { get; set; }

    public virtual WydatkiPracownikow WppWpr { get; set; } = null!;
}
