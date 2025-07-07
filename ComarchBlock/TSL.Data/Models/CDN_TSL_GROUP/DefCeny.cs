using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DefCeny
{
    public int DfCDfCid { get; set; }

    public int DfCLp { get; set; }

    public string DfCNazwa { get; set; } = null!;

    public byte DfCAktualizacja { get; set; }

    public decimal DfCMarza { get; set; }

    public decimal DfCZaokraglenie { get; set; }

    public decimal DfCOffset { get; set; }

    public string DfCWaluta { get; set; } = null!;

    public byte DfCTyp { get; set; }

    public short? DfCNieaktywna { get; set; }

    public int? DfCXlLp { get; set; }
}
