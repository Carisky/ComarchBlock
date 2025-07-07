using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Ankiety
{
    public int AntId { get; set; }

    public int? AntRodzaj { get; set; }

    public short? AntAktywna { get; set; }

    public string? AntKod { get; set; }

    public string? AntNazwa { get; set; }

    public byte? AntPodmiotWymagany { get; set; }

    public byte? AntAnonimowa { get; set; }

    public virtual ICollection<PytaniaAnkiety> PytaniaAnkieties { get; set; } = new List<PytaniaAnkiety>();
}
