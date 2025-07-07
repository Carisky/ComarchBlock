using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class DekretyFiltryElem
{
    public int DfeDfnid { get; set; }

    public short DfeId { get; set; }

    public int? DfeParId { get; set; }

    public short? DfeLp { get; set; }

    public byte? DfePoziom { get; set; }

    public byte? DfeTyp { get; set; }

    public byte? DfeOperator { get; set; }

    public byte? DfeGrupa { get; set; }

    public byte? DfePoleTyp { get; set; }

    public int? DfePole { get; set; }

    public byte? DfeZnak { get; set; }

    public string? DfeWartosc { get; set; }

    public int? DfeWartoscId { get; set; }

    public string? DfeWartoscNazwa { get; set; }

    public string? DfeWartoscElement { get; set; }

    public byte? DfeArchiwalny { get; set; }

    public virtual DekretyFiltryNag DfeDfn { get; set; } = null!;
}
