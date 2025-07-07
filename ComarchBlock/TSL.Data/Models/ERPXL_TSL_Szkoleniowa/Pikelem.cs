using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Pikelem
{
    public short? PieGidtyp { get; set; }

    public int? PieGidfirma { get; set; }

    public int PieGidnumer { get; set; }

    public short PieGidlp { get; set; }

    public string? PieZnacznik { get; set; }

    public string? PieKod { get; set; }

    public string? PieNazwisko { get; set; }

    public string? PieImie { get; set; }

    public int? PieFrSid { get; set; }

    public virtual Piknag PieGidnumerNavigation { get; set; } = null!;

    public virtual ICollection<Pikkwoty> Pikkwoties { get; set; } = new List<Pikkwoty>();
}
