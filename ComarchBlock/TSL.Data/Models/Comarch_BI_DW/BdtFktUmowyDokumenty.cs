using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktUmowyDokumenty
{
    public int UdoId { get; set; }

    public int? UdoInsertTransformationId { get; set; }

    public int? UdoInsertSubTransformationId { get; set; }

    public int? UdoUpdateTransformationId { get; set; }

    public int? UdoUpdateSubTransformationId { get; set; }

    public DateTime UdoTsupdate { get; set; }

    public DateTime UdoTsinsert { get; set; }

    public string? UdoOpis { get; set; }

    public string UdoDirtyOrgId { get; set; } = null!;

    public string UdoOrgId { get; set; } = null!;

    public int UdoCzdid { get; set; }

    public int UdoZrodgid { get; set; }

    public int UdoUmnid { get; set; }

    public int UdoDokNumerId { get; set; }
}
