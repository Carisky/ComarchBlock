using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PlanSprzedazy
{
    public int PspId { get; set; }

    public string? PspNazwa { get; set; }

    public int? PspDataOd { get; set; }

    public int? PspDataDo { get; set; }

    public byte? PspTyp { get; set; }

    public byte? PspDataZrodlPozaOkres { get; set; }

    public int? PspDataUtworzenia { get; set; }

    public int? PspOpeNumerU { get; set; }

    public int? PspOpeNumerM { get; set; }

    public short? PspStan { get; set; }

    public string? PspOpis { get; set; }

    public int? PspAktywny { get; set; }

    public int? PspCzasModyfikacji { get; set; }

    public virtual ICollection<PlanSprzedazyKnt> PlanSprzedazyKnts { get; set; } = new List<PlanSprzedazyKnt>();

    public virtual ICollection<PlanSprzedazyRej> PlanSprzedazyRejs { get; set; } = new List<PlanSprzedazyRej>();

    public virtual ICollection<PlanSprzedazyTwr> PlanSprzedazyTwrs { get; set; } = new List<PlanSprzedazyTwr>();
}
