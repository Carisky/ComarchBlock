using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class OfertyDok
{
    public int OfDOfDid { get; set; }

    public string OfDNazwa { get; set; } = null!;

    public string OfDOperator { get; set; } = null!;

    public int? OfDKntId { get; set; }

    public int? OfDFaktId { get; set; }

    public string OfDBody { get; set; } = null!;
}
