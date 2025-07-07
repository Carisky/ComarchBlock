using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PytaniaAnkiety
{
    public int PanAntId { get; set; }

    public int PanPytId { get; set; }

    public decimal? PanPytWaga { get; set; }

    public decimal? PanGrupWaga { get; set; }

    public string? PanOpis { get; set; }

    public short? PanPozycja { get; set; }

    public virtual Ankiety PanAnt { get; set; } = null!;
}
