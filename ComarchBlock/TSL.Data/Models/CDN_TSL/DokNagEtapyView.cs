using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DokNagEtapyView
{
    public int DnEDnEid { get; set; }

    public int? DnEDnPrId { get; set; }

    public int? DnETyp { get; set; }

    public string? DnESymbol { get; set; }

    public string? DnENazwa { get; set; }

    public int DnEOpeId { get; set; }

    public short DnEWykonany { get; set; }

    public byte DnEObowiazkowy { get; set; }

    public byte DnECzyTerminWykonania { get; set; }

    public DateTime DnETerminWykonania { get; set; }

    public DateTime DnETerminOd { get; set; }

    public DateTime DnETerminDo { get; set; }

    public byte DnERezerwujCzas { get; set; }

    public byte DnEPrzypomnienie { get; set; }

    public DateTime DnECzasPrzypomnienia { get; set; }

    public string? DnEKomentarz { get; set; }
}
