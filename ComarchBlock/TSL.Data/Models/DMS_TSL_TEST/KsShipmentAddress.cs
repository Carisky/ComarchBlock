using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsShipmentAddress
{
    public int KsyId { get; set; }

    public int KsyTransportId { get; set; }

    public byte KsyType { get; set; }

    public string? KsyKodKraju { get; set; }

    public string? KsyAdres { get; set; }

    public string? KsyGln { get; set; }

    public virtual KsTransport KsyTransport { get; set; } = null!;
}
