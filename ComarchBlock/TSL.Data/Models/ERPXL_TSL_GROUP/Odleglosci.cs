using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Odleglosci
{
    public int OdlId { get; set; }

    public string? OdlNazwa { get; set; }

    public short? OdlOdTyp { get; set; }

    public int? OdlOdFirma { get; set; }

    public int? OdlOdNumer { get; set; }

    public short? OdlOdLp { get; set; }

    public short? OdlDoTyp { get; set; }

    public int? OdlDoFirma { get; set; }

    public int? OdlDoNumer { get; set; }

    public short? OdlDoLp { get; set; }

    public decimal? OdlOdleglosc { get; set; }
}
