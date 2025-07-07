using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class BnkCertyfikaty
{
    public int BnCBnCid { get; set; }

    public int BnCBnaId { get; set; }

    public int? BnCOpeId { get; set; }

    public int BnCTypOperacji { get; set; }

    public string BnCNazwa { get; set; } = null!;

    public string? BnCThumbprint { get; set; }

    public string? BnCContent { get; set; }

    public DateTime? BnCExpirationDate { get; set; }

    public virtual BnkNazwy BnCBna { get; set; } = null!;
}
