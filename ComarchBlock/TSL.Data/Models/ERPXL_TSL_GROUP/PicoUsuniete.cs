using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PicoUsuniete
{
    public int PcUId { get; set; }

    public int? PcUPcKid { get; set; }

    public int? PcUObiTyp { get; set; }

    public int? PcUObiNumer { get; set; }

    public int? PcUObiektTyp { get; set; }

    public int? PcUObiektId { get; set; }

    public int? PcUTsusuniecia { get; set; }

    public byte? PcUStan { get; set; }

    public string? PcUIdent { get; set; }

    public int? PcUPsaId { get; set; }

    public virtual PicoKonfig? PcUPcK { get; set; }
}
