using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PrzelewyNag
{
    public int PpnId { get; set; }

    public string? PpnRejestr { get; set; }

    public short? PpnRok { get; set; }

    public byte? PpnMiesiac { get; set; }

    public int? PpnNumer { get; set; }

    public byte? PpnStatus { get; set; }

    public int? PpnDataDokumentu { get; set; }

    public int? PpnDataRealizacji { get; set; }

    public int? PpnOpeWystNumer { get; set; }

    public int? PpnOpeModyfNumer { get; set; }

    public int? PpnOpeZatwNumer { get; set; }

    public int? PpnOpeRealizNumer { get; set; }

    public int? PpnRealizTs { get; set; }

    public string? PpnUrl { get; set; }

    public string? PpnOpis { get; set; }

    public string? PpnUwagi { get; set; }

    public int? PpnAktywny { get; set; }

    public virtual Rejestry? PpnRejestrNavigation { get; set; }

    public virtual ICollection<PrzelewyAutoryzacje> PrzelewyAutoryzacjes { get; set; } = new List<PrzelewyAutoryzacje>();

    public virtual ICollection<PrzelewyElem> PrzelewyElems { get; set; } = new List<PrzelewyElem>();

    public virtual PrzelewyNagPodpisy? PrzelewyNagPodpisy { get; set; }
}
