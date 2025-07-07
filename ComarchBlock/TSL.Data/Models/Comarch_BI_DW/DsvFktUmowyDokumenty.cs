using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktUmowyDokumenty
{
    public int UdoCzdid { get; set; }

    public string UdoDirtyOrgId { get; set; } = null!;

    public int UdoDokNumerId { get; set; }

    public int UdoId { get; set; }

    public int? UdoInsertSubTransformationId { get; set; }

    public int? UdoInsertTransformationId { get; set; }

    public string? UdoOpis { get; set; }

    public string UdoOrgId { get; set; } = null!;

    public DateTime UdoTsinsert { get; set; }

    public DateTime UdoTsupdate { get; set; }

    public int UdoUmnid { get; set; }

    public int? UdoUpdateSubTransformationId { get; set; }

    public int? UdoUpdateTransformationId { get; set; }

    public int UdoZrodgid { get; set; }
}
