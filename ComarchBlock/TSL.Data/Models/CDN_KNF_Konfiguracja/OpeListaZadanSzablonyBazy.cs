using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OpeListaZadanSzablonyBazy
{
    public int OpZsbOpZsbid { get; set; }

    public int OpZsbSzablonId { get; set; }

    public int OpZsbLp { get; set; }

    public int OpZsbOpeId { get; set; }

    public int OpZsbBazId { get; set; }

    public Guid? OpZsbBazaGuid { get; set; }

    public virtual OpeListaZadanSzablony OpZsbSzablon { get; set; } = null!;
}
