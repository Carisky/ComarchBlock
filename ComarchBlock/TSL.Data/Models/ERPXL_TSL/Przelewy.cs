using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Przelewy
{
    public long PpxId { get; set; }

    public short? PpxTrptyp { get; set; }

    public int? PpxTrpfirma { get; set; }

    public int? PpxTrpnumer { get; set; }

    public short? PpxTrplp { get; set; }

    public decimal? PpxKwotaAkc { get; set; }

    public decimal? PpxKwotaExp { get; set; }

    public int? PpxExpId { get; set; }

    public int? PpxExpLin { get; set; }

    public byte? PpxStatus { get; set; }

    public int? PpxPpnid { get; set; }

    public short? PpxPpelp { get; set; }

    public virtual PrzelewyElem? PrzelewyElem { get; set; }

    public virtual TraPlat? TraPlat { get; set; }
}
