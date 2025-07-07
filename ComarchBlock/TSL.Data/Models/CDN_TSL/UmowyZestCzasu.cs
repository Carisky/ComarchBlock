using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class UmowyZestCzasu
{
    public int UmzUmzId { get; set; }

    public int UmzUmwId { get; set; }

    public int UmzRok { get; set; }

    public short UmzMiesiac { get; set; }

    public DateTime? UmzCzas { get; set; }

    public string? UmzImportRowId { get; set; }

    public virtual Umowy UmzUmw { get; set; } = null!;
}
