using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsBankAccount
{
    public int KsbId { get; set; }

    public int KsbDocumentId { get; set; }

    public string? KsbNrRachunku { get; set; }

    public string? KsbNrRachunkuSwift { get; set; }

    public byte? KsbRachunekWlasnyBanku { get; set; }

    public string? KsbNazwaBanku { get; set; }

    public string? KsbOpisRachunku { get; set; }

    public virtual KsDocument KsbDocument { get; set; } = null!;
}
