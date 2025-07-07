using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PlanyObciazeniaGniazd
{
    public int PogId { get; set; }

    public int? PogOpeWnumer { get; set; }

    public int? PogOpeMnumer { get; set; }

    public int? PogDataUtworzenia { get; set; }

    public int? PogDataModyfikacji { get; set; }

    public byte? PogGlowny { get; set; }

    public int? PogGlownyOd { get; set; }

    public byte? PogArchiwalny { get; set; }

    public string? PogOpis { get; set; }

    public short? PogRok { get; set; }

    public byte? PogMiesiac { get; set; }

    public string? PogSeria { get; set; }

    public int? PogNumer { get; set; }

    public int? PogFrsId { get; set; }

    public int? PogFrmNumer { get; set; }

    public int? PogAktywny { get; set; }

    public int? PogPtoid { get; set; }

    public virtual ICollection<PlanyObciazeniaPozycje> PlanyObciazeniaPozycjes { get; set; } = new List<PlanyObciazeniaPozycje>();

    public virtual ICollection<PlanySkladnikiObciazenium> PlanySkladnikiObciazenia { get; set; } = new List<PlanySkladnikiObciazenium>();
}
