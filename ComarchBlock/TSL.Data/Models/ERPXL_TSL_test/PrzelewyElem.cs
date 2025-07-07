using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PrzelewyElem
{
    public int PpePpnid { get; set; }

    public short PpePpelp { get; set; }

    public byte? PpeOdrzucona { get; set; }

    public short? PpeLp { get; set; }

    public short? PpeGrpPpelp { get; set; }

    public byte? PpeGrupa { get; set; }

    public string? PpeTytulWyrazenie { get; set; }

    public string? PpeTytulWartosc { get; set; }

    public string? PpeTytulSeparator { get; set; }

    public byte? PpeTytulModyfikowany { get; set; }

    public byte? PpePodzialGrupy { get; set; }

    public short? PpePodzialIloscZnakow { get; set; }

    public int? PpeModyfOpeNumer { get; set; }

    public int? PpeModyfData { get; set; }

    public virtual OpeKarty? PpeModyfOpeNumerNavigation { get; set; }

    public virtual PrzelewyNag PpePpn { get; set; } = null!;

    public virtual Przelewy? Przelewy { get; set; }
}
