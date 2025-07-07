using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PodSelem
{
    public short PosGidtyp { get; set; }

    public int? PosGidfirma { get; set; }

    public int PosGidnumer { get; set; }

    public short PosGidlp { get; set; }

    public short PosTypSkladnika { get; set; }

    public int? PosPozycja { get; set; }

    public string? PosOpis { get; set; }

    public decimal? PosKwotaL { get; set; }

    public decimal? PosKwotaM { get; set; }

    public virtual PodElem PodElem { get; set; } = null!;
}
