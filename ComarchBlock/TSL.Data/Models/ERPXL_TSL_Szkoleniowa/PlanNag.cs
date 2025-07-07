using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PlanNag
{
    public int PlnId { get; set; }

    public int? PlnPlanZrodlowy { get; set; }

    public int? PlnDataUtworz { get; set; }

    public int? PlnOpeNumerW { get; set; }

    public int? PlnDataZatw { get; set; }

    public int? PlnOpeNumerZ { get; set; }

    public short? PlnRok { get; set; }

    public byte? PlnMiesiac { get; set; }

    public string? PlnSeria { get; set; }

    public int? PlnNumer { get; set; }

    public byte? PlnAnulowano { get; set; }

    public short? PlnStan { get; set; }

    public int? PlnFrsid { get; set; }

    public string? PlnOpis { get; set; }

    public int? PlnFrmNumer { get; set; }
}
