using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwUrzParDef
{
    public int SudId { get; set; }

    public string? SudNazwa { get; set; }

    public string? SudFormat { get; set; }

    public short? SudSlwTyp { get; set; }

    public int? SudSlwNumer { get; set; }

    public byte? SudArchiwalna { get; set; }

    public virtual ICollection<SrwUrzParam> SrwUrzParams { get; set; } = new List<SrwUrzParam>();

    public virtual ICollection<SrwUrzRodzPar> SrwUrzRodzPars { get; set; } = new List<SrwUrzRodzPar>();
}
