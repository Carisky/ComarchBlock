using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SrsWypRodzaje
{
    public int RwpId { get; set; }

    public string? RwpNazwa { get; set; }

    public int? RwpSlwId { get; set; }

    public int? RwpSsDid { get; set; }

    public int? RwpTyp { get; set; }

    public int? RwpAktywny { get; set; }

    public short? RwpTerminPrzegladu { get; set; }
}
