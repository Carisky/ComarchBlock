using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class KntWeryfStatHist
{
    public int KwshKwshid { get; set; }

    public int KwshKntId { get; set; }

    public string KwshNip { get; set; } = null!;

    public byte KwshTypWeryfikacji { get; set; }

    public DateTime KwshData { get; set; }

    public int KwshStatus { get; set; }

    public virtual Kontrahenci KwshKnt { get; set; } = null!;
}
