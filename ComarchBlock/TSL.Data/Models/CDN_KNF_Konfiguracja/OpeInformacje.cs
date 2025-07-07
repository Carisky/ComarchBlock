using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OpeInformacje
{
    public int OpIOpIid { get; set; }

    public int OpIOpeId { get; set; }

    public int? OpIBazId { get; set; }

    public int OpIInfId { get; set; }

    public byte OpIKanal { get; set; }

    public virtual Informacje OpIInf { get; set; } = null!;

    public virtual Operatorzy OpIOpe { get; set; } = null!;
}
