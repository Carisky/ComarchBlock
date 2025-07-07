using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DekretyKontum
{
    public int DeKDeKid { get; set; }

    public int DeKDeEid { get; set; }

    public int DeKDeNid { get; set; }

    public int DeKDziId { get; set; }

    public int DeKAccId { get; set; }

    public byte DeKStrona { get; set; }

    public DateTime DeKDataDok { get; set; }

    public decimal DeKKwota { get; set; }

    public decimal DeKKwotaWal { get; set; }

    public string DeKWaluta { get; set; } = null!;

    public byte DeKBufor { get; set; }

    public virtual Kontum DeKAcc { get; set; } = null!;
}
