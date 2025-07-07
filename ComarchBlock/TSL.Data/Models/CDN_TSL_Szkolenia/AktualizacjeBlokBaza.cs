using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AktualizacjeBlokBaza
{
    public int AktBbId { get; set; }

    public string? AktBbUzytkownik { get; set; }

    public DateTime? AktBbCzas { get; set; }
}
