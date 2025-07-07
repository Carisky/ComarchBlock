using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class RetroKontrahenci
{
    public int RktId { get; set; }

    public int? RktRtKid { get; set; }

    public short? RktKntTyp { get; set; }

    public int? RktKntFirma { get; set; }

    public int? RktKntNumer { get; set; }

    public short? RktKntLp { get; set; }

    public string? RktWaluta { get; set; }

    public string? RktAkronimGrupy { get; set; }

    public int? RktRktId { get; set; }

    public virtual ICollection<RetroKntOkresy> RetroKntOkresies { get; set; } = new List<RetroKntOkresy>();

    public virtual RetroKarty RktRtK { get; set; } = null!;
}
