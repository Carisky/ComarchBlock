using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ReklOperacjeDef
{
    public int RodId { get; set; }

    public string? RodNazwa { get; set; }

    public string? RodOpis { get; set; }

    public short? RodDokTyp { get; set; }

    public byte? RodDostepna { get; set; }

    public byte? RodStanPo { get; set; }

    public byte? RodStatus { get; set; }

    public byte? RodOpublikowana { get; set; }

    public byte? RodArchiwalna { get; set; }

    public int? RodKluczowa { get; set; }
}
