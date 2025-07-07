using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class UsunieteObiekty
{
    public int UobUobId { get; set; }

    public int UobTyp { get; set; }

    public string UobImportRowId { get; set; } = null!;
}
