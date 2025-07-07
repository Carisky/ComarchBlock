using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwPlanPrzegladu
{
    public int SppId { get; set; }

    public short? SppRok { get; set; }

    public byte? SppMiesiac { get; set; }

    public string? SppSeria { get; set; }

    public int? SppNumer { get; set; }

    public string? SppDokumentObcy { get; set; }

    public byte? SppStan { get; set; }

    public int? SppFrsId { get; set; }

    public int? SppFrmNumer { get; set; }

    public int? SppAktywny { get; set; }

    public short? SppKntTyp { get; set; }

    public int? SppKntNumer { get; set; }

    public int? SppSurid { get; set; }

    public int? SppStpid { get; set; }

    public int? SppOkresOd { get; set; }

    public int? SppOkresDo { get; set; }

    public int? SppDataW { get; set; }

    public int? SppOpeNumerW { get; set; }

    public int? SppDataZ { get; set; }

    public int? SppOpeNumerZ { get; set; }

    public int? SppPrjId { get; set; }

    public virtual ICollection<SrwPlanElem> SrwPlanElems { get; set; } = new List<SrwPlanElem>();
}
