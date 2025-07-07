using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class OpPracKod
{
    public int SyncId { get; set; }

    public int Id { get; set; }

    public int Ts { get; set; }

    public byte Akcja { get; set; }
}
