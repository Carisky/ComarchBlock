using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class IstotneOpcje
{
    public string IopIdprocedury { get; set; } = null!;

    public string IopNazwaKontrolki { get; set; } = null!;

    public string IopNazwaOpcji { get; set; } = null!;

    public int IopIdoperatora { get; set; }

    public int? IopLicznik { get; set; }

    public virtual OpeKarty IopIdoperatoraNavigation { get; set; } = null!;
}
