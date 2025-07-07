using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Apfino
{
    public int ApfId { get; set; }

    public short? ApfTrNtyp { get; set; }

    public int? ApfTrNfirma { get; set; }

    public int? ApfTrNnumer { get; set; }

    public short? ApfTrNlp { get; set; }

    public short? ApfUsluga { get; set; }

    public string? ApfApfinoId { get; set; }

    public string? ApfKod { get; set; }

    public string? ApfKodWartosc { get; set; }

    public int? ApfData { get; set; }

    public decimal? ApfZgloszonaKwotaSys { get; set; }

    public string? ApfFileId { get; set; }

    public virtual TraNag? ApfTrNnumerNavigation { get; set; }
}
