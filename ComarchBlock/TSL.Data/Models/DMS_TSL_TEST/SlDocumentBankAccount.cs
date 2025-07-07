using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class SlDocumentBankAccount
{
    public int Id { get; set; }

    public string? Number { get; set; }

    public int? DocumentId { get; set; }

    public virtual SlDocument? Document { get; set; }
}
