using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DetalAtrybuty
{
    public int DatrDatrId { get; set; }

    public int DatrOptimaId { get; set; }

    public int DatrStanDetalId { get; set; }

    public int DatrDsatrId { get; set; }

    public int DatrObjectType { get; set; }

    public int DatrObjectId { get; set; }

    public int DatrClassId { get; set; }

    public int DatrValueId { get; set; }

    public string DatrValue { get; set; } = null!;

    public string DatrFormat { get; set; } = null!;

    public int DatrValueType { get; set; }
}
