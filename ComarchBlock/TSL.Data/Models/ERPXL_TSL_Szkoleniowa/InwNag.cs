using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class InwNag
{
    public int InNId { get; set; }

    public int? InNTstampOtw { get; set; }

    public short? InNOpeTypO { get; set; }

    public int? InNOpeFirmaO { get; set; }

    public int? InNOpeNumerO { get; set; }

    public short? InNOpeLpO { get; set; }

    public int? InNTstampZam { get; set; }

    public short? InNOpeTypZ { get; set; }

    public int? InNOpeFirmaZ { get; set; }

    public int? InNOpeNumerZ { get; set; }

    public short? InNOpeLpZ { get; set; }

    public int? InNCzasModyfikacji { get; set; }

    public string? InNOpis { get; set; }

    public byte? InNRodzajBlokady { get; set; }

    public short? InNPrzyrostowa { get; set; }

    public byte? InNTylkoNiezerowe { get; set; }

    public byte? InNDzielNaPartie { get; set; }

    public byte? InNPolozenie { get; set; }

    public byte? InNRodzajIlosci { get; set; }

    public byte? InNWycenaNadwyzek { get; set; }

    public byte? InNOddzielnieMag { get; set; }

    public int? InNExtId { get; set; }

    public string? InNNazwa { get; set; }

    public string? InNGuid { get; set; }

    public byte? InNRealizujWpos { get; set; }

    public int? InNPostypId { get; set; }

    public virtual ICollection<InwArk> InwArks { get; set; } = new List<InwArk>();

    public virtual ICollection<InwMag> InwMags { get; set; } = new List<InwMag>();

    public virtual ICollection<InwTwr> InwTwrs { get; set; } = new List<InwTwr>();
}
