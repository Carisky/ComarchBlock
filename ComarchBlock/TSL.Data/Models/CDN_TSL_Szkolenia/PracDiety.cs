using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PracDiety
{
    public int PdiPdiId { get; set; }

    public int PdiPraId { get; set; }

    public DateTime PdiOkresOd { get; set; }

    public DateTime PdiOkresDo { get; set; }

    public decimal PdiKwotaDiety { get; set; }

    public string PdiKraj { get; set; } = null!;

    public string? PdiImportRowId { get; set; }

    public virtual PracKod PdiPra { get; set; } = null!;
}
