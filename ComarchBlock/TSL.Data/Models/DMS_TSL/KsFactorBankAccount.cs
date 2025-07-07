using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class KsFactorBankAccount
{
    public int KskId { get; set; }

    public int KskDocumentId { get; set; }

    public string? KskFaktorNrRachunku { get; set; }

    public string? KskFaktorNrRachunkuSwift { get; set; }

    public byte? KskFaktorRachunekWlasnyBanku { get; set; }

    public string? KskFaktorNazwaBanku { get; set; }

    public string? KskFaktorOpisBanku { get; set; }

    public virtual KsDocument KskDocument { get; set; } = null!;
}
